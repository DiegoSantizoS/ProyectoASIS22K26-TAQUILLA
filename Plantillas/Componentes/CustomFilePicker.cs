using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomFilePicker : UserControl
    {
        private readonly Label _display;
        private readonly Panel _button;
        private string _filePath = "";

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FilePath
        {
            get => _filePath;
            set
            {
                _filePath = value ?? "";
                _display.Text = string.IsNullOrEmpty(_filePath)
                    ? "Seleccionar imagen..."
                    : Path.GetFileName(_filePath);
                _display.ForeColor = string.IsNullOrEmpty(_filePath)
                    ? Color.FromArgb(160, 165, 175)
                    : Color.FromArgb(230, 230, 230);
            }
        }

        [DefaultValue("Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif")]
        public string Filter { get; set; } = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

        public event EventHandler FileSelected;

        public CustomFilePicker()
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
                ForeColor = Color.FromArgb(160, 165, 175),
                Font = new Font("Segoe UI", 8.5f),
                Padding = new Padding(8, 0, 0, 0),
                Cursor = Cursors.Hand,
                AutoEllipsis = true,
                Text = "Seleccionar imagen..."
            };
            _display.Click += (s, e) => Browse();

            _button = new Panel
            {
                Dock = DockStyle.Right,
                Width = 26,
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };
            _button.Paint += DrawFolderIcon;
            _button.Click += (s, e) => Browse();

            Controls.Add(_display);
            Controls.Add(_button);
        }

        private void DrawFolderIcon(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = _button.Width;
            int h = _button.Height;
            int fw = 14;
            int fh = 11;
            int x = (w - fw) / 2;
            int y = (h - fh) / 2;

            using (var body = new SolidBrush(Color.FromArgb(60, 65, 78)))
            using (var pen = new Pen(Color.FromArgb(60, 65, 78), 1))
            {
                Rectangle tab = new Rectangle(x, y, 6, 3);
                g.FillRectangle(body, tab);

                Rectangle main = new Rectangle(x, y + 2, fw, fh - 2);
                g.FillRectangle(body, main);
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

        private void Browse()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = Filter;
                dialog.Title = "Seleccionar imagen";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    FileSelected?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}