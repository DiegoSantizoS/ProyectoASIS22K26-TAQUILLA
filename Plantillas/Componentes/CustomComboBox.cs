/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using ReaLTaiizor.Controls;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Componentes
{
    public class CustomComboBox : ForeverComboBox
    {
        public CustomComboBox()
        {
            Font = new Font("Segoe UI", 9f);
            ItemHeight = 24;
            Margin = new Padding(5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cursor = Cursors.Hand;
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(0, 30);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */