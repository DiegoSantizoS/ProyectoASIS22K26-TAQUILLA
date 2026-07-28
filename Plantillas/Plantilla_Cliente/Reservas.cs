using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Cliente
{
    public partial class Reservas : UserControl
    {
        public int idPelicula;
        public int id_funcion;
        public int numero_boleto;
        public int id_venta;
        public string estado_boleto = "";
        public List<int> asientoseleccionado = new List<int>();
        private conexion gconexion;
        public Reservas()
        {
            InitializeComponent();
            gconexion = new conexion();
        }
        public Reservas(int idPelicula)
        {
            InitializeComponent();
            //CargarInformacion(idPelicula);
            this.idPelicula = idPelicula;
            MessageBox.Show($"ID recibido: {this.idPelicula}");
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
                    List<int> asientos = butacas.ButacasSeleccionadas;

                    MessageBox.Show(string.Join(", ", asientos));
                }
            }
        }

        private void Tx_Restriccion_Click(object sender, EventArgs e)
        {

        }
    }
}
