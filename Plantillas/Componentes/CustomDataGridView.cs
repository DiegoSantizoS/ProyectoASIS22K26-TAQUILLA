/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomDataGridView : DataGridView
    {
        [DefaultValue(typeof(Color), "45, 47, 52")]
        public Color HeaderBackColor { get; set; } = Color.FromArgb(45, 47, 52);

        [DefaultValue(typeof(Color), "White")]
        public Color HeaderForeColor { get; set; } = Color.White;

        [DefaultValue(typeof(Color), "42, 44, 49")]
        public Color RowAlternateColor { get; set; } = Color.FromArgb(42, 44, 49);

        public CustomDataGridView()
        {
            Dock = DockStyle.Fill;
            Margin = new Padding(0);
            BorderStyle = BorderStyle.None;
            BackgroundColor = Color.FromArgb(37, 38, 43);
            GridColor = Color.FromArgb(58, 60, 66);
            Font = new Font("Segoe UI", 9.5f);
            DoubleBuffered = true;

            AllowUserToAddRows = false;
            AllowUserToResizeRows = false;
            AllowUserToResizeColumns = false;
            RowHeadersVisible = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            ReadOnly = true;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            EnableHeadersVisualStyles = false;
            ColumnHeadersDefaultCellStyle.BackColor = HeaderBackColor;
            ColumnHeadersDefaultCellStyle.ForeColor = HeaderForeColor;
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderBackColor;
            ColumnHeadersHeight = 42;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            RowTemplate.Height = 36;

            DefaultCellStyle.BackColor = Color.FromArgb(37, 38, 43);
            DefaultCellStyle.ForeColor = Color.FromArgb(230, 230, 230);
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 44, 48);
            DefaultCellStyle.SelectionForeColor = Color.White;
            DefaultCellStyle.Padding = new Padding(8, 0, 5, 0);

            AlternatingRowsDefaultCellStyle.BackColor = RowAlternateColor;
            AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(230, 230, 230);
            AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 44, 48);
            AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */