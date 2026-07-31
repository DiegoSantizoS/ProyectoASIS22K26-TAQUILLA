/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
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
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */