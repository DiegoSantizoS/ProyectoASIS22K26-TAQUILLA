using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomTimePicker : MaskedTextBox
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TimeSpan Value
        {
            get
            {
                if (TimeSpan.TryParse(Text, out var t))
                    return new TimeSpan(t.Hours, t.Minutes, 0);
                return TimeSpan.Zero;
            }
            set => Text = $"{value.Hours:00}:{value.Minutes:00}";
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsValid =>
            TimeSpan.TryParse(Text, out var t) && t.Hours < 24 && t.Minutes < 60;

        public CustomTimePicker()
        {
            Mask = "00:00";
            BorderStyle = BorderStyle.FixedSingle;
            BackColor = Color.FromArgb(55, 60, 72);
            ForeColor = Color.FromArgb(230, 230, 230);
            Font = new Font("Segoe UI", 11f);
            TextAlign = HorizontalAlignment.Center;
            Margin = new Padding(5);
            Padding = new Padding(0);
            Anchor = AnchorStyles.None;
            MinimumSize = new Size(190, 30);
            Size = new Size(190, 30);
            Text = "1200";
        }
    }
}