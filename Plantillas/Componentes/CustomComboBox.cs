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
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Font = new Font("Segoe UI", 9f);
            ForeColor = Color.FromArgb(230, 230, 230);
            BackColor = Color.FromArgb(55, 60, 72);
            Margin = new Padding(5);
            Padding = new Padding(0);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cursor = Cursors.Hand;
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI", 9.5F);
            FormattingEnabled = true;
            ItemHeight = 24;
            Margin = new Padding(5);
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(0, 30);

            BackColor = Color.FromArgb(55, 60, 72);
            BaseColor = Color.FromArgb(40, 40, 40);
            BGColor = Color.FromArgb(55, 60, 72);
            ForeColor = Color.FromArgb(230, 230, 230);
            HoverColor = Color.Crimson;
            HoverFontColor = Color.White;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */