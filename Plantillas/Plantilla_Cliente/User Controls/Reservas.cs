using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Forms;
using clase_conexion;
using Plantilla_Cliente.Clases;
using System.Diagnostics;




namespace Plantilla_Cliente
{
    public partial class Reservas : UserControl
    {
        private Con_Cliente gconexion;

        // Película seleccionada
        public int idcine;
        public int idPelicula;
        public int idciudad;
        public string Enlace;
        // Datos de la reserva
        public int id_funcion;
        public int numero_boleto;
        public int id_venta;
        public string estado_boleto = "";
        public int IdSala;

        // Asientos seleccionados
        public List<int> asientosSeleccionados = new List<int>();

        //Lista de boletos Generados
        public List<Boleto> boletosGenerados = new List<Boleto>();

        // Botones para mostrar la fecha y hora seleccionadas
        private Button btnFechaSeleccionada = null;
        private Button btnHoraSeleccionada = null;

        public Reservas()
        {
            InitializeComponent();
            gconexion = new Con_Cliente();

        }

        public Reservas(int idPelicula, int idciudad)
        {
            InitializeComponent();
            gconexion = new Con_Cliente();
            this.idPelicula = idPelicula;
            this.idciudad = idciudad;

            // Prueba para verificar que el ID se recibió correctamente
            /*MessageBox.Show($"ID recibido: {this.idPelicula}");
            MessageBox.Show($"Ciudad recibida: {this.idciudad}");*/
            Enlace = gconexion.ObtenerEnlacePelicula(idPelicula);
            cargarinfopelicula(this.idPelicula);
            cargarfunciones(this.idPelicula, this.idciudad);
            CargarCines(this.idciudad);
            Flp_Horarios.Controls.Clear();
            CargarMiniaturaTrailer(Enlace);

        }

        private void TlP_Reservas_Paint(object sender, PaintEventArgs e)
        {
            AplicarBordeLabel(Tx_Director, Color.FromArgb(112, 27, 40));
            AplicarBordeLabel(Tx_Duracion, Color.FromArgb(112, 27, 40));
            AplicarBordeLabel(Tx_Restriccion, Color.FromArgb(112, 27, 40));
            AplicarBordeLabel(Tx_DirectorHead, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(Tx_DuracionHead, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(Tx_RestriccionHead, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(Tx_SeleccionCine, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(Tx_Funciones, Color.FromArgb(18, 18, 18));
            AplicarBordeLabel(Tx_Horarios, Color.FromArgb(18, 18, 18));
        }
        /*Inicio del código 0901-23-13862 Carlos Andres Arriaza Lara el 25/07/2026*/
        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            using (Butacas butacas = new Butacas(IdSala))
            {
                if (butacas.ShowDialog() == DialogResult.OK)
                {
                    // Guardar los números de asiento
                    asientosSeleccionados = new List<int>(butacas.ButacasSeleccionadas);

                    // Mostrar los asientos decodificados (solo para prueba)
                    List<string> asientosTexto = new List<string>();

                    foreach (int numero in asientosSeleccionados)
                    {
                        asientosTexto.Add(DecodificarAsiento(numero));
                    }

                    MessageBox.Show(
                        "Asientos seleccionados:\n" +
                        string.Join(", ", asientosTexto));

                    MessageBox.Show("Id_Funcion" + id_funcion.ToString());
                    GuardarButacas();
                }
            }
        }

        private string DecodificarAsiento(int numeroAsiento)
        {
            int fila = (numeroAsiento - 1) / 10;
            int columna = (numeroAsiento - 1) % 10 + 1;

            char letraFila = (char)('A' + fila);

            return $"{letraFila}{columna}";
        }
        /*Fin del código de 0901-23-13862 Carlos Andres Arriaza Lara el 25/07/2026*/
        private void cargarinfopelicula(int idPelicula)
        {
            String director = "";
            string duracion = "";
            string restriccion = "";
            DataTable pelicula = gconexion.infopelicula(idPelicula);
            Tx_Director.Text = pelicula.Rows[0]["director_pelicula"].ToString();
            Tx_Duracion.Text = pelicula.Rows[0]["duracion_pelicula"].ToString();
            Tx_Restriccion.Text = pelicula.Rows[0]["clasificacion_pelicula"].ToString();

        }
        private void cargarfunciones(int idPelicula, int idciudad)
        {
            Flp_Funciones.Controls.Clear();
            //MessageBox.Show($"Película: {idPelicula}\nCiudad: {idciudad}");
            DataTable funciones = gconexion.cargarfunciones(idPelicula, idciudad);
            //MessageBox.Show($"Filas: {funciones.Rows.Count}");
            HashSet<DateTime> fechas = new HashSet<DateTime>();
            foreach (DataRow fila in funciones.Rows)
            {
                DateTime fecha = Convert.ToDateTime(fila["fecha_funcion"]);

                if (fechas.Contains(fecha))
                    continue;

                fechas.Add(fecha);

                Button btn = new Button();

                btn.AutoSize = true;
                btn.Height = 40;
                btn.Margin = new Padding(5);
                btn.Dock = DockStyle.Fill;
                btn.Text = fecha.ToString("dd/MM");
                btn.Tag = fecha;

                btn.BackColor = Color.FromArgb(197, 155, 39);
                btn.ForeColor = Color.FromArgb(250, 248, 245);
                btn.FlatStyle = FlatStyle.Popup;
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += BtnFecha_Click;

                Flp_Funciones.Controls.Add(btn);
            }
        }
        private void CargarHorarios(DateTime fechaSeleccionada)
        {
            //MessageBox.Show("IdCiudad:" + idciudad.ToString());
            Flp_Horarios.Controls.Clear();
            //MessageBox.Show($"Película: {idPelicula}\nCiudad: {idciudad}");
            DataTable funciones = gconexion.cargarfunciones(idPelicula, idciudad);
            //MessageBox.Show($"Filas: {funciones.Rows.Count}");
            foreach (DataRow fila in funciones.Rows)
            {
                DateTime fechaFuncion = Convert.ToDateTime(fila["fecha_funcion"]);

                if (fechaFuncion.Date != fechaSeleccionada.Date)
                    continue;

                Button btn = new Button();

                btn.AutoSize = true;
                btn.Height = 40;
                btn.Margin = new Padding(5);

                btn.Text = fila["hora_funcion"].ToString();

                btn.Tag = Convert.ToInt32(fila["id_funcion"]);
                btn.Dock = DockStyle.Fill;
                btn.BackColor = Color.FromArgb(197, 155, 39);
                btn.ForeColor = Color.FromArgb(250, 248, 245);
                btn.FlatStyle = FlatStyle.Popup;
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += BtnHorario_Click;
                //MessageBox.Show($"Creando botón: {fila["hora_funcion"]}");
                Flp_Horarios.Controls.Add(btn);
            }
        }
        private void BtnFecha_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btnFechaSeleccionada != null)
            {
                btnFechaSeleccionada.BackColor = Color.FromArgb(197, 155, 39);
                btnFechaSeleccionada.ForeColor = Color.FromArgb(250, 248, 245);
            }
            btn.BackColor = Color.FromArgb(112, 27, 40);


            btnFechaSeleccionada = btn;

            DateTime fecha = (DateTime)btn.Tag;

            CargarHorarios(fecha);
        }
        private void BtnHorario_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btnHoraSeleccionada != null)
            {
                btnHoraSeleccionada.BackColor = Color.FromArgb(197, 155, 39);
                btnHoraSeleccionada.ForeColor = Color.FromArgb(250, 248, 245);
            }


            btn.BackColor = Color.FromArgb(112, 27, 40);
            btn.ForeColor = Color.White;

            btnHoraSeleccionada = btn;

            id_funcion = (int)btn.Tag;
            //MessageBox.Show($"Id función: {id_funcion}");
            IdSala = gconexion.ObtenerIdSala(id_funcion);
            // MessageBox.Show($"Id_Funcion: {id_funcion}\nId_Sala: {IdSala}");
        }

        private void Cbo_Cines_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcine = Cbo_Cines.SelectedIndex + 1;
            cargarfunciones(idPelicula, idcine);

        }

        private void CargarCines(int ciudad)
        {

            DataTable dtCines = gconexion.mostrarcines(ciudad);

            Cbo_Cines.DataSource = null;

            Cbo_Cines.DisplayMember = "nombre_cine";
            Cbo_Cines.ValueMember = "id_cine";

            Cbo_Cines.DataSource = dtCines;
            //MessageBox.Show($"Cines cargados: {dtCines.Rows.Count}");
        }
        private void GuardarButacas()
        {
            int idVenta = gconexion.SiguienteIdVenta();
            int ultimoIdBoleto = gconexion.SiguienteIdBoleto();

            foreach (int asiento in asientosSeleccionados)
            {
                int idBoleto = ultimoIdBoleto++;

                boletosGenerados.Add(
                    new Boleto(idBoleto, id_funcion, asiento, idVenta, "Reservado"));
                MessageBox.Show($"Boleto generado: IdBoleto={idBoleto}, IdFuncion={id_funcion}, Asiento={asiento}, IdVenta={idVenta}, Estado=Reservado");
            }
        }
        private void AplicarBordeLabel(Label lbl, Color colorBorde)
        {
            lbl.Paint += (object sender, PaintEventArgs e) =>
            {
                using (Pen pen = new Pen(colorBorde, 2))
                {
                    e.Graphics.DrawRectangle(
                        pen,
                        0,
                        0,
                        lbl.Width - 1,
                        lbl.Height - 1);
                }
            };
        }

        private void PicTrailer_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Enlace,
                UseShellExecute = true
            });
        }
        private void CargarMiniaturaTrailer(string enlaceYoutube)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(enlaceYoutube))
                {
                    PicTrailer.Image = null;
                    return;
                }

                Uri uri = new Uri(enlaceYoutube);
                string videoId = "";

                if (uri.Host.Contains("youtu.be"))
                {
                    // Ejemplo: https://youtu.be/mY-XSIfhziE?si=xxxx
                    videoId = uri.AbsolutePath.Trim('/');
                }
                else if (uri.Host.Contains("youtube.com"))
                {
                    // Ejemplo: https://www.youtube.com/watch?v=mY-XSIfhziE
                    string query = uri.Query.TrimStart('?');

                    foreach (string parametro in query.Split('&'))
                    {
                        if (parametro.StartsWith("v="))
                        {
                            videoId = parametro.Substring(2);
                            break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(videoId))
                {
                    PicTrailer.LoadAsync($"https://img.youtube.com/vi/{videoId}/hqdefault.jpg");
                }
                else
                {
                    PicTrailer.Image = null;
                }
            }
            catch
            {
                PicTrailer.Image = null;
            }
        }

    }
}