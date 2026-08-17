<<<<<<< HEAD
﻿using Plantilla_Admin.Tabs;
=======
﻿/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 22/07/2026 */

using Plantilla_Admin.Tabs;
using Plantilla_Admin.FormulariosPrincipales;
using Plantilla_Cliente;
>>>>>>> main
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Plantilla_Admin.FormulariosPrincipales
{
    public partial class FrMenu : Form
    {
        private Button _activeButton = null;

        public FrMenu()
        {
            InitializeComponent();
            WireNavButtons();
<<<<<<< HEAD
        }


        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in PnlTop.Controls) c.Dispose();
=======
            funcargarpagina(new FrUcMainDashboard());
            LbUsuarioDescripcion.Text = Sesion.Descripcion();
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in PnlMain.Controls) c.Dispose();
>>>>>>> main
            PnlMain.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(pagina);
        }
        private void WireNavButtons()
        {
            Button[] navButtons =
            {
                BtnFunciones, BtnVentas, BtnUsuarios, BtnReportes, BtnAyuda, BtnSalir
            };

            foreach (Button b in navButtons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.FromArgb(74, 21, 26);
                b.ForeColor = Color.FromArgb(220, 210, 210);

                b.MouseEnter += NavButton_MouseEnter;
                b.MouseLeave += NavButton_MouseLeave;
                b.Click += NavButton_Click;
            }
        }

        private void ActiveBtn(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(224, 196, 84);
            btn.FlatAppearance.BorderSize = 2;
            btn.BackColor = Color.FromArgb(120, 30, 34);
            btn.ForeColor = Color.White;
        }

        private void InactiveBtn(Button btn)
        {
<<<<<<< HEAD
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(74, 21, 26);
            btn.ForeColor = Color.FromArgb(220, 210, 210);
=======
            if (btn != null)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(74, 21, 26);
                btn.ForeColor = Color.FromArgb(220, 210, 210);
            }
>>>>>>> main
        }

        private void SetActive(Button btn)
        {
            if (_activeButton != null)
                InactiveBtn(_activeButton);

            _activeButton = btn;
            ActiveBtn(btn);
        }

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != _activeButton)
            {
                btn.BackColor = Color.FromArgb(178, 44, 48);
                btn.ForeColor = Color.White;
            }
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != _activeButton)
            {
                btn.BackColor = Color.FromArgb(74, 21, 26);
                btn.ForeColor = Color.FromArgb(220, 210, 210);
            }
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (sender is Button btn)
                SetActive(btn);
=======
           if (sender is Button btn && success)
             SetActive(btn);
>>>>>>> main
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
<<<<<<< HEAD
=======
        
>>>>>>> main
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

<<<<<<< HEAD
        private void BtnFunciones_Click(object sender, EventArgs e)
        {
=======
        private bool success = false;
        private void BtnFunciones_Click(object sender, EventArgs e)
        {
            var permisos = PermisosAux.DeSesion(
                AplicacionPermiso.Funciones,
                AccionPermiso.Mantenimiento
            );

            if (!permisos.Permitido())
            {
                success = false;
                MessageBox.Show("No tienes permiso para esta sección.");
                return;
            }
            success = true;
>>>>>>> main
            funcargarpagina(new FrUcMainFunciones());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            success = true;
>>>>>>> main
            funcargarpagina(new FrUcMainVentas());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            funcargarpagina(new FrUcMainUsuarios());
        }   

        private void BtnReportes_Click(object sender, EventArgs e)
        {
=======
            success = true;
            funcargarpagina(new FrUcMainUsuarios());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            success = true;
>>>>>>> main
            funcargarpagina(new FrUcMainReportes());
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            success = true;
>>>>>>> main
            funcargarpagina(new FrUcMainAyuda());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
        }
    }
}
=======
            FrLogin menu = new FrLogin();
            menu.FormClosed += (s, args) => this.Close();
            this.Hide();
            menu.Show();
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            funcargarpagina(new FrUcMainDashboard());
            InactiveBtn(_activeButton);
        }

        private void TlpDescripcionUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 05/08/2026 */
>>>>>>> main
