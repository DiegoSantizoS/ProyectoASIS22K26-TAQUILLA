using clase_conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrCuBuscarCartelera1 : UserControl
    {
        private DataTable dtGeneros;
        public event EventHandler<int> IrAEditar;


        public FrCuBuscarCartelera1()
        {
            InitializeComponent();

            conexion conexion = new conexion();

            //Dgv_cartelera.AutoGenerateColumns = false;
            Dgv_cartelera.DataSource = conexion.mostrarCartelera();

            Dgv_cartelera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_cartelera.ReadOnly = true;
            Dgv_cartelera.MultiSelect = false;
        }

        private void Dgv_cartelera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_cartelera.CurrentRow != null)
            {
                int id = Convert.ToInt32(Dgv_cartelera.CurrentRow.Cells["ID"].Value);
                string titulo = Dgv_cartelera.CurrentRow.Cells["Nombre"].Value.ToString();

                Txt_id.Text = id.ToString();
                Txt_nombre.Text = titulo;
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_id.Text))
            {
                MessageBox.Show("Selecciona una película de la lista primero.");
                return;
            }

            int id = Convert.ToInt32(Txt_id.Text);
            IrAEditar?.Invoke(this, id);
        }


    }
}
