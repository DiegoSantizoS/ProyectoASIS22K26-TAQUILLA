using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomDatePicker : UserControl
    {
        private readonly Label _display;
        private readonly Panel _button;
        private readonly MonthCalendar _calendar;
        private readonly ToolStripDropDown _dropDown;
        private DateTime _value = DateTime.Today;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Value
        {
            get => _value;
            set
            {
                _value = value;
                _display.Text = _value.ToString(CustomFormat);
                _display.ForeColor = Color.FromArgb(230, 230, 230);
            }
        }

        [DefaultValue("dd/MM/yyyy")]
        public string CustomFormat { get; set; } = "dd/MM/yyyy";

        public CustomDatePicker()
        {
            Size = new Size(190, 30);
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(190, 30);
            Margin = new Padding(5);
            Padding = new Padding(1);
            Anchor = AnchorStyles.None;
            BackColor = Color.FromArgb(55, 60, 72);
            DoubleBuffered = true;

            _display = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(55, 60, 72),
                ForeColor = Color.FromArgb(230, 230, 230),
                Font = new Font("Segoe UI", 8.5f),
                Padding = new Padding(8, 0, 0, 0),
                Cursor = Cursors.Hand,
                AutoEllipsis = true,
                Text = _value.ToString(CustomFormat)
            };
            _display.Click += (s, e) => ShowCalendar();

            _button = new Panel
            {
                Dock = DockStyle.Right,
                Width = 26,
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };
            _button.Paint += DrawCalendarIcon;
            _button.Click += (s, e) => ShowCalendar();

            _calendar = new MonthCalendar
            {
                MaxSelectionCount = 1,
                TitleBackColor = Color.FromArgb(41, 128, 185),
                TitleForeColor = Color.White
            };
            _calendar.DateSelected += (s, e) =>
            {
                Value = e.Start;
                _dropDown.Close();
            };

            var host = new ToolStripControlHost(_calendar)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty
            };
            _dropDown = new ToolStripDropDown { Padding = Padding.Empty };
            _dropDown.Items.Add(host);

            Controls.Add(_display);
            Controls.Add(_button);
        }

        private void DrawCalendarIcon(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = _button.Width;
            int h = _button.Height;
            int cw = 14;
            int ch = 13;
            int x = (w - cw) / 2;
            int y = (h - ch) / 2;

            Color ink = Color.FromArgb(60, 65, 78);
            using (var pen = new Pen(ink, 1.4f))
            using (var fill = new SolidBrush(ink))
            {
                Rectangle body = new Rectangle(x, y + 2, cw, ch - 2);
                g.DrawRectangle(pen, body);

                g.FillRectangle(fill, x, y + 2, cw + 1, 3);

                g.DrawLine(pen, x + 4, y, x + 4, y + 3);
                g.DrawLine(pen, x + cw - 4, y, x + cw - 4, y + 3);

                using (var dot = new SolidBrush(ink))
                {
                    for (int row = 0; row < 2; row++)
                        for (int col = 0; col < 3; col++)
                            g.FillRectangle(dot, x + 2 + col * 4, y + 7 + row * 3, 2, 2);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Color.White, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }

        private void ShowCalendar()
        {
            _calendar.SetDate(_value);
            _dropDown.Show(this, 0, Height);
        }
    }
}