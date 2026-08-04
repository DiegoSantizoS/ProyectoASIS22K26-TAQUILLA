/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using Forms_Admin.Ventas;
using Forms_Admin.Ventas.Catalogs;
using Formularios_Admin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantilla_Admin.Tabs
{
    public partial class FrUcMainVentas : UserControl
    {
        private Button _activeButton = null;

        private static readonly Color IdleBack = Color.Black;
        private static readonly Color HoverBack = Color.FromArgb(120, 30, 34);
        private static readonly Color ActiveBack = Color.FromArgb(178, 44, 48);
        private static readonly Color IdleFore = Color.FromArgb(220, 210, 210);

        public FrUcMainVentas()
        {
            InitializeComponent();
            WireNavButtons();

            BtnVentas.PerformClick();
        }

        private void WireNavButtons()
        {
            Button[] navButtons = { BtnVentas, BtnBoletos, BtnClientes };

            foreach (Button b in navButtons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = IdleBack;
                b.ForeColor = IdleFore;
                //b.FlatAppearance.MouseOverBackColor = Color.Transparent;

                b.MouseEnter += NavButton_MouseEnter;
                b.MouseLeave += NavButton_MouseLeave;
            }

            BtnVentas.Click += (s, e) => Navegar(BtnVentas, new FrUcVentas());
            BtnBoletos.Click += (s, e) => Navegar(BtnBoletos, new FrUcBoletos());
            BtnClientes.Click += (s, e) => Navegar(BtnClientes, new FrUcClientes());

            CbCatalog.SelectedIndexChanged += CbCatalog_SelectedIndexChanged;
        }

        private void Navegar(Button btn, UserControl pagina)
        {
            SetActive(btn);
            ResetCombo();
            funcargarpagina(pagina);
        }

        private void SetActive(Button btn)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = IdleBack;
                _activeButton.ForeColor = IdleFore;
            }

            _activeButton = btn;
            btn.BackColor = ActiveBack;
            btn.ForeColor = Color.White;
        }

        private void ResetActiveButton()
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = IdleBack;
                _activeButton.ForeColor = IdleFore;
                _activeButton = null;
            }
        }

        private void HighlightCombo()
        {
            CbCatalog.StateCommon.ComboBox.Back.Color1 = ActiveBack;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = Color.White;
        }

        private void ResetCombo()
        {
            CbCatalog.StateCommon.ComboBox.Back.Color1 = IdleBack;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = IdleFore;
        }

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != _activeButton)
            {
                btn.BackColor = ActiveBack;
                btn.ForeColor = Color.White;
            }
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != _activeButton)
            {
                btn.BackColor = IdleBack;
                btn.ForeColor = IdleFore;
            }
        }

        private void CbCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetActiveButton();
            HighlightCombo();

            switch (CbCatalog.SelectedItem?.ToString())
            {
                case "Estados De Boleto":
                    funcargarpagina(new FrUcEstadosDeBoleto());
                    break;
                case "Métodos De Pago":
                    funcargarpagina(new FrUcMetodosDePago());
                    break;
                default:
                    break;
            }
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in PnlMain.Controls) c.Dispose();
            PnlMain.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(pagina);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 03/08/2026 */