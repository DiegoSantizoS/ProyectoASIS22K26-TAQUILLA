using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Cliente
{
    public partial class Reservas : UserControl
    {
        private int idPelicula;
        public Reservas()
        {
            InitializeComponent();
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
                if(butacas.ShowDialog() == DialogResult.OK)
                {
                    //Se accede a la lista de asientos del formulario Butacas y se guardaran para crear los boletos
                    List<int> asientos = butacas.ButacasSeleccionadas;

                    MessageBox.Show(string.Join(", ", asientos));
                }
            }
        }
    }
}
