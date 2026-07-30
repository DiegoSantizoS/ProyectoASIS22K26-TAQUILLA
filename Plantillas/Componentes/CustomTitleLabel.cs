using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomTitleLabel : Label
    {
        [DefaultValue(typeof(Color), "41, 128, 185")]
        public Color AccentColor { get; set; } = Color.FromArgb(41, 128, 185);

        public CustomTitleLabel()
        {
            AutoSize = false;
            Font = new Font("Segoe UI", 18f, FontStyle.Bold);
            ForeColor = Color.FromArgb(41, 128, 185);
            TextAlign = ContentAlignment.MiddleCenter;
            Dock = DockStyle.Fill;
            Height = 50;
            Text = "Título";
        }
    }
}