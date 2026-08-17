using System;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Admin.FormulariosPrincipales
{
    public partial class FrConexion : Form
    {
        private readonly conexion db;

        public FrConexion()
        {
            InitializeComponent();

            db = new conexion();

            TbServer.Text = db.Server;
            TbUser.Text = db.User;
            TbPassword.Text = db.Password;

            TbPassword.UseSystemPasswordChar = true;

            BtnGuardar.Click += BtnGuardar_Click;

            KeyPreview = true;

            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnGuardar.PerformClick();
                    e.Handled = true;
                }
            };
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbServer.Text))
            {
                MessageBox.Show(
                    "Ingresa el servidor.",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TbServer.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TbUser.Text))
            {
                MessageBox.Show(
                    "Ingresa el usuario.",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TbUser.Focus();
                return;
            }

            bool conectado = db.GuardarCredenciales(
                TbServer.Text,
                TbUser.Text,
                TbPassword.Text
            );

            if (!conectado)
            {
                MessageBox.Show(
                    "No se pudo conectar con los datos ingresados.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            MessageBox.Show(
                "Conexión configurada correctamente.",
                "Conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}