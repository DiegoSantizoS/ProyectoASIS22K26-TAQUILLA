using clase_conexion;
using Con_Admin;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Forms_Admin.Usuarios
{
    public partial class FrUcBitacora : UserControl
    {
        public FrUcBitacora()
        {
            InitializeComponent();
            CargarBitacora();
        }

        private readonly If_Bitacora datosBitacora = new If_Bitacora();

        private void CargarBitacora()
        {
            try
            {
                DgvBitacora.DataSource = datosBitacora.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }
    }
}