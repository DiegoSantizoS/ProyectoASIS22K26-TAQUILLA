using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomTextBox : UserControl
    {
        private readonly TextBox _input;
        private string _placeholder = "";
        private bool _showingPlaceholder = false;

        private readonly Color _textColor = Color.FromArgb(230, 230, 230);
        private readonly Color _placeholderColor = Color.FromArgb(160, 165, 175);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => _showingPlaceholder ? "" : (_input?.Text ?? "");
            set
            {
                if (_input != null)
                {
                    _input.Text = value;
                    UpdatePlaceholder();
                }
            }
        }

        [DefaultValue("")]
        public string PlaceholderText
        {
            get => _placeholder;
            set
            {
                _placeholder = value ?? "";
                UpdatePlaceholder();
            }
        }

        public event EventHandler TextChangedInput;

        public CustomTextBox()
        {
            Size = new Size(190, 30);
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(190, 30);
            Margin = new Padding(0);
            Padding = new Padding(1);
            Anchor = AnchorStyles.None;
            BackColor = Color.FromArgb(55, 60, 72);
            DoubleBuffered = true;


            _input = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10f),
                ForeColor = _textColor,
                BackColor = Color.FromArgb(55, 60, 72)
            };
            _input.Enter += Input_Enter;
            _input.Leave += Input_Leave;
            _input.TextChanged += (s, e) =>
            {
                if (!_showingPlaceholder)
                    TextChangedInput?.Invoke(this, e);
            };

            Controls.Add(_input);
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            if (_showingPlaceholder)
            {
                _showingPlaceholder = false;
                _input.Text = "";
                _input.ForeColor = _textColor;
            }
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            UpdatePlaceholder();
        }

        private void UpdatePlaceholder()
        {
            if (_input == null) return;

            if (string.IsNullOrEmpty(_input.Text) && !_input.Focused && !string.IsNullOrEmpty(_placeholder))
            {
                _showingPlaceholder = true;
                _input.Text = _placeholder;
                _input.ForeColor = _placeholderColor;
            }
            else if (_showingPlaceholder && _input.Focused)
            {
                _showingPlaceholder = false;
                _input.Text = "";
                _input.ForeColor = _textColor;
            }
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (_input == null) return;
            int left = Padding.Left + 5;
            int width = ClientSize.Width - left - Padding.Right - 5;
            int top = (ClientSize.Height - _input.Height) / 2;
            _input.SetBounds(left, top, width, _input.Height);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (_input == null) return;
            _input.Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Color.FromArgb(90, 96, 110), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}