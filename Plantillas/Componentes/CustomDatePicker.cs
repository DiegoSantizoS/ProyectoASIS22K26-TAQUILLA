/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomDatePicker : KryptonDateTimePicker
    {
        public CustomDatePicker()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd/MM/yyyy";
            Font = new Font("Segoe UI", 9.5f);
            Margin = new Padding(5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(0, 30);

            StateCommon.Back.Color1 = Color.FromArgb(55, 60, 72);
            StateCommon.Border.Color1 = Color.FromArgb(40, 40, 40);
            StateCommon.Border.Color2 = Color.FromArgb(40, 40, 40);
            StateCommon.Content.Color1 = Color.FromArgb(230, 230, 230);

            StateActive.Back.Color1 = Color.FromArgb(55, 60, 72);
            StateActive.Border.Color1 = Color.FromArgb(40, 40, 40);
            StateActive.Border.Color2 = Color.FromArgb(40, 40, 40);
            StateActive.Content.Color1 = Color.FromArgb(230, 230, 230);

            PaletteMode = PaletteMode.Microsoft365BlackDarkModeAlternate;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */