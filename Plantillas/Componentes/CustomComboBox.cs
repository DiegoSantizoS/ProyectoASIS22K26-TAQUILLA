using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawFixed;
            Font = new Font("Segoe UI", 9f);
            ForeColor = Color.FromArgb(230, 230, 230);
            BackColor = Color.FromArgb(55, 60, 72);
            Margin = new Padding(5);
            Padding = new Padding(0);
            Anchor = AnchorStyles.None;
            Cursor = Cursors.Hand;
            ItemHeight = 26;
            MinimumSize = new Size(190, 30);
            Size = new Size(190, 30);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) { e.DrawBackground(); return; }

            bool isEditArea = (e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color back = (selected && !isEditArea)
                ? Color.FromArgb(41, 128, 185)
                : Color.FromArgb(55, 60, 72);

            using (var b = new SolidBrush(back))
                e.Graphics.FillRectangle(b, e.Bounds);

            TextRenderer.DrawText(e.Graphics, GetItemText(Items[e.Index]), Font,
                new Rectangle(e.Bounds.X + 6, e.Bounds.Y, e.Bounds.Width - 6, e.Bounds.Height),
                Color.FromArgb(230, 230, 230),
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int arrowBoxW = 20;
            Rectangle arrowBox = new Rectangle(Width - arrowBoxW, 0, arrowBoxW, Height);

            using (var b = new SolidBrush(Color.White))
                e.Graphics.FillRectangle(b, arrowBox);

            int cx = arrowBox.Left + arrowBox.Width / 2;
            int cy = Height / 2;
            using (var arrow = new SolidBrush(Color.FromArgb(60, 65, 78)))
            {
                Point[] tri =
                {
                    new Point(cx - 4, cy - 2),
                    new Point(cx + 4, cy - 2),
                    new Point(cx, cy + 3)
                };
                e.Graphics.FillPolygon(arrow, tri);
            }

            using (var pen = new Pen(Color.White, 1))
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }
    }
}