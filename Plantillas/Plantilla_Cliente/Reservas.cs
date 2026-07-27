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
        public Reservas(int IdPelicula)
        {
            InitializeComponent();
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
                    
                }
            }
        }
    }
}
