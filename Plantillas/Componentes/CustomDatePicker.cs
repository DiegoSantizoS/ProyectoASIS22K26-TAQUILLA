/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomDatePicker : DateTimePicker
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

            CalendarForeColor = Color.FromArgb(230, 230, 230);
            CalendarMonthBackground = Color.FromArgb(55, 60, 72);
            CalendarTitleBackColor = Color.FromArgb(41, 128, 185);
            CalendarTitleForeColor = Color.White;
            CalendarTrailingForeColor = Color.FromArgb(150, 150, 150);
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */