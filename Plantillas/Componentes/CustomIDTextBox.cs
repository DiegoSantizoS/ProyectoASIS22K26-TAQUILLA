/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
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

    public class CustomIDTextBox : TextBox
    {
        private IDState _state = IDState.Normal;
        private bool _editable = false;

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
                ReadOnly = !_editable;
                TabStop = _editable;
                Cursor = _editable ? Cursors.IBeam : Cursors.Default;
            }
        }

        public CustomIDTextBox()
        {
            Font = new Font("Segoe UI", 10f);
            BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AutoSize = false;
            MinimumSize = new Size(190, 30);
            Size = new Size(190, 30);

            ReadOnly = true;
            TabStop = false;
            Cursor = Cursors.Default;

            ApplyState();
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
            ForeColor = fore;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (!_editable)
            {
                HideCaret(Handle);
                Parent?.SelectNextControl(this, true, true, true, true);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!_editable)
            {
                HideCaret(Handle);
                Parent?.SelectNextControl(this, true, true, true, true);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */