/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 01/08/2026 */
using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomListBox : KryptonListBox
    {
        public CustomListBox()
        {
            StateCheckedNormal.Item.Content.LongText.Font = new Font("Segoe UI", 8.5f);
            StateCheckedNormal.Item.Content.ShortText.Font = new Font("Segoe UI", 8.5f);

            Margin = new Padding(5);
            Cursor = Cursors.Hand;
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Dock = DockStyle.Fill;
            Margin = new Padding(5,10,5,10);

            StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);

            StateCommon.Item.Back.Color1 = Color.FromArgb(55, 60, 72);
            StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            StateCommon.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);

            StateTracking.Item.Back.Color1 = Color.Crimson;
            StateTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            StateTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);

            StateCheckedNormal.Item.Back.Color1 = Color.Crimson;
            StateCheckedNormal.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            StateCheckedNormal.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);

            StateCheckedTracking.Item.Back.Color1 = Color.Crimson;
            StateCheckedTracking.Item.Content.ShortText.Color1 = Color.FromArgb(230, 230, 230);
            StateCheckedTracking.Item.Content.LongText.Color1 = Color.FromArgb(230, 230, 230);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 01/08/2026 */