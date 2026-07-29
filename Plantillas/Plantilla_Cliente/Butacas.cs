using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Cliente
{
    public partial class Butacas : Form
    {
        public List<int> ButacasSeleccionadas { get; } = new();
        public Butacas()
        {
            InitializeComponent();
        }

        private void Butacas_Load(object sender, EventArgs e)
        {
            CrearButacas(7);
        }
        private void CrearButacas(int filas)
        {
            int columnas = 10;
            //Limpiar el TableLayoutPanel antes de agregar nuevos botones y también limpiar las filas y columnas existentes
            Tlp_butacaselector.Controls.Clear();
            Tlp_butacaselector.ColumnStyles.Clear();
            Tlp_butacaselector.RowStyles.Clear();

            Tlp_butacaselector.RowCount = filas;
            Tlp_butacaselector.ColumnCount = columnas;
            //Establecer el tamaño en porcentaje de cada columna
            for (int i = 0; i < columnas; i++)
            {
                Tlp_butacaselector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            }
            //Establecer el tamaño en porcentaje de cada fila

            for (int i = 0; i < filas; i++)
            {
                Tlp_butacaselector.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / filas));
            }
            //Crear los botones de las butacas
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    int numeroButaca = fila * columnas + columna + 1;
                    Button butaca = new Button();
                    butaca.Dock = DockStyle.Fill;
                    butaca.BackColor = Color.Green;
                    butaca.ForeColor = Color.White;
                    butaca.FlatStyle = FlatStyle.Flat;
                    butaca.Tag = numeroButaca;
                    butaca.Text = DecodificarAsiento(numeroButaca);
                    butaca.Click += Btn_butaca_Click;
                    Tlp_butacaselector.Controls.Add(butaca, columna, fila);

                }
            }
        }
        private void Btn_butaca_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int numeroAsiento = (int)btn.Tag;


            if (btn.BackColor == Color.Green)
            {
                //añadir el asiento seleccionado a la lista
                btn.BackColor = Color.DeepSkyBlue;
                ButacasSeleccionadas.Add(numeroAsiento);
            }
            else
            {
                //Eliminar el asiento seleccionado de la lista
                btn.BackColor = Color.Green;
                ButacasSeleccionadas.Remove(numeroAsiento);
            }
        }

        private void Btn_Confirmacion_Click(object sender, EventArgs e)
        {
            //Si no hay butacas seleccionadas, mostrar un mensaje de error y salir del método
            if (ButacasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una butaca",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro que desea reservar {ButacasSeleccionadas.Count} butacas?\n\n" +
                $"Butacas seleccionadas: {string.Join(", ", ButacasSeleccionadas)}",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            //Enviar contenido de la lista hacia afuera del formulario
            if (respuesta == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private string DecodificarAsiento(int NumeroAsiento)
        {
            int fila = (NumeroAsiento - 1) / 10;
            int columna = (NumeroAsiento - 1) % 10 + 1;
            char letra = (char)('A' + fila);
            
            return $"{letra}{columna}";
        }
        
    }
}
