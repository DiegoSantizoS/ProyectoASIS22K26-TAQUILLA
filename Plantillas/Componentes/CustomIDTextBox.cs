using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public enum IDState
    {
        Normal,
        Valid,
        Invalid
    }

    public class CustomIDTextBox : UserControl
    {
        private readonly TextBox _input;
        private IDState _state = IDState.Normal;
        private bool _editable = false;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get => _input.Text;
            set => _input.Text = value;
        }

        [DefaultValue(IDState.Normal)]
        public IDState State
        {
            get => _state;
            set
            {
                _state = value;
                ApplyState();
            }
        }

        [DefaultValue(false)]
        public bool Editable
        {
            get => _editable;
            set
            {
                _editable = value;
                _input.ReadOnly = !_editable;
                _input.TabStop = _editable;
                _input.Cursor = _editable ? Cursors.IBeam : Cursors.Default;
            }
        }

        public CustomIDTextBox()
        {
            Size = new Size(190, 30);
            MinimumSize = new Size(190, 30);
            Margin = new Padding(0);
            Padding = new Padding(1);
            Anchor = AnchorStyles.None;
            BackColor = Color.FromArgb(45, 49, 60);
            DoubleBuffered = true;

            _input = new TextBox
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10f),
                ReadOnly = true,
                TabStop = false,
                Cursor = Cursors.Default
            };
            _input.Enter += Input_Enter;
            _input.GotFocus += Input_GotFocus;
            _input.MouseDown += Input_MouseDown;

            Controls.Add(_input);
            ApplyState();
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            if (!_editable)
            {
                HideCaret(_input.Handle);
                Parent?.SelectNextControl(this, true, true, true, true);
            }
        }

        private void Input_GotFocus(object sender, EventArgs e)
        {
            if (!_editable)
                HideCaret(_input.Handle);
        }

        private void Input_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_editable)
            {
                HideCaret(_input.Handle);
                Parent?.SelectNextControl(this, true, true, true, true);
            }
        }

        private void ApplyState()
        {
            Color back, fore;
            switch (_state)
            {
                case IDState.Valid:
                    back = Color.FromArgb(39, 174, 96);
                    fore = Color.White;
                    break;
                case IDState.Invalid:
                    back = Color.FromArgb(192, 57, 43);
                    fore = Color.White;
                    break;
                default:
                    back = Color.FromArgb(45, 49, 60);
                    fore = Color.FromArgb(160, 165, 175);
                    break;
            }

            BackColor = back;
            if (_input != null)
            {
                _input.BackColor = back;
                _input.ForeColor = fore;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Color.FromArgb(90, 96, 110), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
    }
}