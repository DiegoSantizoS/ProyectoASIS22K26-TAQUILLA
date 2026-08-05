/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 03/08/2026 */
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Componentes
{
    public class TableLayoutSlider : Panel
    {
        private readonly System.Windows.Forms.Timer _anim;

        private int _openWidth = 250;
        private int _closedWidth = 60;
        private int _step = 4;
        private int _targetWidth;
        private bool _isOpen = true;

        [DefaultValue(250)]
        public int OpenWidth
        {
            get => _openWidth;
            set { _openWidth = value; if (_isOpen) Width = value; }
        }

        [DefaultValue(60)]
        public int ClosedWidth
        {
            get => _closedWidth;
            set { _closedWidth = value; if (!_isOpen) Width = value; }
        }

        [DefaultValue(4)]
        public int Step
        {
            get => _step;
            set => _step = Math.Max(1, value);
        }

        [Browsable(false)]
        public bool IsOpen => _isOpen;

        public TableLayoutSlider()
        {
            DoubleBuffered = true;
            Width = _openWidth;

            _anim = new System.Windows.Forms.Timer { Interval = 15 };
            _anim.Tick += Animate;
        }

        public void Open()
        {
            _isOpen = true;
            _targetWidth = _openWidth;
            _anim.Start();
        }

        public void Close()
        {
            _isOpen = false;
            _targetWidth = _closedWidth;
            _anim.Start();
        }

        public void Toggle()
        {
            if (_isOpen) Close();
            else Open();
        }

        private void Animate(object sender, EventArgs e)
        {
            int diff = _targetWidth - Width;

            if (Math.Abs(diff) <= _step)
            {
                Width = _targetWidth;
                _anim.Stop();
                return;
            }

            Width += diff / _step;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Open();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!ClientRectangle.Contains(PointToClient(MousePosition)))
                Close();
        }

    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 03/08/2026 */