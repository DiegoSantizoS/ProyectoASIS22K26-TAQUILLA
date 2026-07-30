using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            AutoSize = false;
            Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            ForeColor = Color.FromArgb(220, 220, 220);
            Padding = new Padding(0, 0, 8, 0);
            Text = "Label";
            Dock = DockStyle.None;
            TextAlign = ContentAlignment.MiddleRight;
            MinimumSize = new Size(125, 50);
            //MaximumSize = new Size(0, 0);
            Size = new Size(125, 50);
        }
    }
}