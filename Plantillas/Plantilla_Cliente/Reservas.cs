using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Plantilla_Cliente
{
    public partial class Reservas : UserControl
    {
        private Conexion gconexion;
        // Película seleccionada
        private int idPelicula;

        // Datos de la reserva
        public int id_funcion;
        public int numero_boleto;
        public int id_venta;
        public string estado_boleto = "";

        // Asientos seleccionados
        public List<int> asientosSeleccionados = new List<int>();

        // Botones para mostrar la fecha y hora seleccionadas
        private Button btnFechaSeleccionada = null;
        private Button btnHoraSeleccionada = null;

        public Reservas()
        {
            InitializeComponent();
        }

        public Reservas(int idPelicula)
        {
            InitializeComponent();
            gconexion = new Conexion();
            this.idPelicula = idPelicula;

            // Prueba para verificar que el ID se recibió correctamente
            MessageBox.Show($"ID recibido: {this.idPelicula}");
            cargarinfopelicula(this.idPelicula);
            cargarfunciones(this.idPelicula);
            
            // Más adelante:
            // CargarInformacionPelicula();
        }

        private void TlP_Reservas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            using (Butacas butacas = new Butacas())
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
        private void cargarinfopelicula(int idPelicula) {
            String director = "";
            string duracion = "";
            string restriccion = "";
            DataTable pelicula = gconexion.infopelicula(idPelicula);
            Tx_Director.Text = pelicula.Rows[0]["director_pelicula"].ToString();
            Tx_Duracion.Text = pelicula.Rows[0]["duracion_pelicula"].ToString();
            Tx_Restriccion.Text = pelicula.Rows[0]["clasificacion_pelicula"].ToString();
        }
        private void cargarfunciones(int idPelicula)
        {
            Flp_Funciones.Controls.Clear();

            DataTable funciones = gconexion.cargarfunciones(idPelicula);
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

                btn.Text = fecha.ToString("dd/MM");
                btn.Tag = fecha;

                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += BtnFecha_Click;

                Flp_Funciones.Controls.Add(btn);
            }
        }
        private void CargarHorarios(DateTime fechaSeleccionada)
        {
            Flp_Horarios.Controls.Clear();
            DataTable funciones = gconexion.cargarfunciones(idPelicula);
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

                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += BtnHorario_Click;

                Flp_Horarios.Controls.Add(btn);
            }
        }
        private void BtnFecha_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btnFechaSeleccionada != null)
                btnFechaSeleccionada.BackColor = Color.White;

            btn.BackColor = Color.FromArgb(68, 75, 245);
            btn.ForeColor = Color.White;

            btnFechaSeleccionada = btn;

            DateTime fecha = (DateTime)btn.Tag;

            CargarHorarios(fecha);
        }
        private void BtnHorario_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btnHoraSeleccionada != null)
                btnHoraSeleccionada.BackColor = Color.White;

            btn.BackColor = Color.FromArgb(68, 75, 245);
            btn.ForeColor = Color.White;

            btnHoraSeleccionada = btn;

            id_funcion = (int)btn.Tag;
        }

    }
}