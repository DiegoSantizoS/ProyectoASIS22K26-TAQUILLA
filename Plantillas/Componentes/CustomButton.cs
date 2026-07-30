using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Componentes
{
    public enum ButtonAction
    {
        Limpiar,
        Ingresar,
        Copiar,
        Actualizar,
        Eliminar,
        Buscar
    }

    public class CustomButton : Button
    {
        private ButtonAction _action = ButtonAction.Ingresar;

        [DefaultValue(ButtonAction.Ingresar)]
        public ButtonAction Action
        {
            get => _action;
            set
            {
                _action = value;
                ApplyStyle();
            }
        }

        [DefaultValue(typeof(Color), "189, 195, 199")]
        public Color OffColor { get; set; } = Color.FromArgb(189, 195, 199);

        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            ForeColor = Color.White;
            Size = new Size(120, 40);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            MinimumSize = new Size(100, 40);
            MaximumSize = new Size(100, 40);
            Size = new Size(100, 40);
            AutoSize = false;
            ApplyStyle();
        }

        private Color BaseColor => _action switch
        {
            ButtonAction.Limpiar => Color.FromArgb(127, 140, 141),
            ButtonAction.Ingresar => Color.FromArgb(41, 128, 185),
            ButtonAction.Copiar => Color.FromArgb(26, 156, 156),
            ButtonAction.Actualizar => Color.FromArgb(214, 157, 15),
            ButtonAction.Eliminar => Color.FromArgb(192, 57, 43),
            ButtonAction.Buscar => Color.FromArgb(39, 174, 96),
            _ => Color.FromArgb(41, 128, 185)
        };

        private void ApplyStyle()
        {
            Color baseColor = BaseColor;
            BackColor = baseColor;
            FlatAppearance.MouseOverBackColor = ControlPaint.Light(baseColor, 0.1f);
            FlatAppearance.MouseDownBackColor = ControlPaint.Dark(baseColor, 0.1f);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (Enabled)
            {
                BackColor = BaseColor;
                ForeColor = Color.White;
                Cursor = Cursors.Hand;
            }
            else
            {
                BackColor = OffColor;
                ForeColor = Color.FromArgb(240, 240, 240);
                Cursor = Cursors.Default;
            }
        }
    }
}