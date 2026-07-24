/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 22/07/2026 */


using Plantilla_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Cliente
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_contrasena_Click(object sender, EventArgs e)
        {

        }

        private void Txt_logo_Click(object sender, EventArgs e)
        {

        }

        private void Txt_usuario_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrMenuAdmin menu = new FrMenuAdmin();
            menu.FormClosed += (s, args) => this.Close();   
            this.Hide();
            menu.Show();
        }
    }
}
