using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Cliente
{
    public partial class Reservas : UserControl
    {
        private conexion gconexion;
        // Película seleccionada
        private int idPelicula;

        // Datos de la reserva
        public int id_funcion;
        public int numero_boleto;
        public int id_venta;
        public string estado_boleto = "";

        // Asientos seleccionados
        public List<int> asientosSeleccionados = new List<int>();

        public Reservas()
        {
            InitializeComponent();
        }

        public Reservas(int idPelicula)
        {
            InitializeComponent();
            gconexion = new conexion();
            this.idPelicula = idPelicula;

            // Prueba para verificar que el ID se recibió correctamente
            MessageBox.Show($"ID recibido: {this.idPelicula}");
            cargarinfopelicula(this.idPelicula);

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
    }
}