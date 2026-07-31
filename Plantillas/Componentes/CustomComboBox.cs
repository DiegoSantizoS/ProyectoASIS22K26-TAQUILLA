/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Font = new Font("Segoe UI", 9f);
            ForeColor = Color.FromArgb(230, 230, 230);
            BackColor = Color.FromArgb(55, 60, 72);
            Margin = new Padding(5);
            Padding = new Padding(0);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cursor = Cursors.Hand;
            ItemHeight = 26;
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(0, 30);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */