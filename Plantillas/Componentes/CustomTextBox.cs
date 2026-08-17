/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomTextBox : TextBox
    {
        private string _placeholder = "";
        private bool _showingPlaceholder = false;

        private readonly Color _textColor = Color.FromArgb(230, 230, 230);
        private readonly Color _placeholderColor = Color.FromArgb(100, 105, 115);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => _showingPlaceholder ? "" : base.Text;
            set
            {
                base.Text = value;
                UpdatePlaceholder();
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
            Font = new Font("Segoe UI", 10f);
            BorderStyle = BorderStyle.FixedSingle;
            ForeColor = _textColor;
            BackColor = Color.FromArgb(55, 60, 72);
            Margin = new Padding(5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AutoSize = false;
            MinimumSize = new Size(190, 30);
            Size = new Size(190, 30);
            MaximumSize = new Size(0, 30);

            UpdatePlaceholder();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (_showingPlaceholder)
            {
                _showingPlaceholder = false;
                base.Text = "";
                ForeColor = _textColor;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            UpdatePlaceholder();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!_showingPlaceholder)
                TextChangedInput?.Invoke(this, e);
        }

        private void UpdatePlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text) && !Focused && !string.IsNullOrEmpty(_placeholder))
            {
                _showingPlaceholder = true;
                base.Text = _placeholder;
                ForeColor = _placeholderColor;
            }
            else if (_showingPlaceholder && Focused)
            {
                _showingPlaceholder = false;
                base.Text = "";
                ForeColor = _textColor;
            }
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */