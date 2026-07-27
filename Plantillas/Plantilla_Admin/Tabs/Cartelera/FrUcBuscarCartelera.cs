using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Admin
{
    public partial class FrCuBuscarCartelera1 : UserControl
    {
        private conexion gconexion;
        public FrCuBuscarCartelera1()
        {
            InitializeComponent();
            gconexion = new conexion();
            cargar();
        }
        private void cargar()
        {
            Dgv_Cartelera.DataSource = gconexion.mostrarpelicula();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            
        }
    }
}
