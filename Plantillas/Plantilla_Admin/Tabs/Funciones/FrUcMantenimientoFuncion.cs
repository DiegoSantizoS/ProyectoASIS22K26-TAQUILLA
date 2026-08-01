using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase_conexion;

namespace Plantilla_Admin.Tabs.Funciones
{
    public partial class FrUcMantenimientoFuncion : UserControl
    {
        private int idFuncion;
        public FrUcMantenimientoFuncion(int id)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public FrUcMantenimientoFuncion()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            conexion conexion = new conexion();

            Cb_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_genero.DataSource = conexion.mostrarPeliculasCombo();
            Cb_genero.ValueMember = "id_pelicula";
            Cb_genero.DisplayMember = "titulo_pelicula";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = conexion.mostrarSalasCombo();
            comboBox1.ValueMember = "id_sala";
            comboBox1.DisplayMember = "descripcion_sala";

            Cb_genero.SelectedIndexChanged += (s, e) => CargarDatosPelicula();
            comboBox1.SelectedIndexChanged += (s, e) => RefrescarHoras();
            dateTimePicker1.ValueChanged += (s, e) => RefrescarHoras();

            dataGridView1.AutoGenerateColumns = true;
            CargarFunciones();

            idFuncion = 0;
            if (idFuncion > 0)
            {
                button1.Text = "ACTUALIZAR";
                CargarFuncion(idFuncion);
            }
            else
            {
                button1.Text = "AGREGAR";
                label6.Text = "-";
            }

            CargarDatosPelicula();
        }

        private void CargarDatosPelicula()
        {
            if (Cb_genero.SelectedValue == null) return;

            int idPel = Convert.ToInt32(Cb_genero.SelectedValue);
            conexion conexion = new conexion();
            DataTable dt = conexion.obtenerPeliculaParaFuncion(idPel);
            if (dt.Rows.Count == 0) return;

            DataRow r = dt.Rows[0];
            label8.Text = r["titulo_pelicula"].ToString();
            label10.Text = r["formato"] == DBNull.Value ? "-" : r["formato"].ToString();
            label12.Text = r["duracion_pelicula"].ToString();
        }

        private void RefrescarHoras()
        {
            if (comboBox1.SelectedValue == null) return;

            int idSala = Convert.ToInt32(comboBox1.SelectedValue);
            conexion conexion = new conexion();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = conexion.horasDeSala(idSala, dateTimePicker1.Value);
            if (dataGridView2.Columns["horas_funcion"] != null)
                dataGridView2.Columns["horas_funcion"].DataPropertyName = "Hora";
        }

        private void CargarFunciones()
        {
            conexion conexion = new conexion();
            dataGridView1.DataSource = conexion.mostrarFunciones();
        }

        private void CargarFuncion(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null &&
                    Convert.ToInt32(row.Cells["ID"].Value) == id)
                {
                    label6.Text = id.ToString();
                    textBox1.Text = row.Cells["Precio"].Value.ToString();
                    textBox2.Text = row.Cells["Hora"].Value.ToString();
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tlp_formulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarFunciones();
            RefrescarHoras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cb_genero.SelectedValue == null) { MessageBox.Show("Selecciona una película."); return; }
            if (comboBox1.SelectedValue == null) { MessageBox.Show("Selecciona una sala."); return; }

            decimal precio;
            if (!decimal.TryParse(textBox1.Text.Trim(), out precio) || precio < 0)
            { MessageBox.Show("Precio inválido."); return; }

            TimeSpan hora;
            if (!TimeSpan.TryParse(textBox2.Text.Trim(), out hora))
            { MessageBox.Show("Hora inválida. Usa formato HH:mm."); return; }

            int idPelicula = Convert.ToInt32(Cb_genero.SelectedValue);
            int idSala = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime fecha = dateTimePicker1.Value.Date;

            try
            {
                conexion conexion = new conexion();
                int idTipoFuncion = conexion.tipoFuncionPorSala(idSala);

                if (idFuncion > 0)
                {
                    conexion.actualizarFuncion(idFuncion, idPelicula, idSala,
                                               idTipoFuncion, fecha, hora, precio);
                    MessageBox.Show("Función actualizada.");
                }
                else
                {
                    int nuevo = conexion.insertarFuncion(idPelicula, idSala,
                                                         idTipoFuncion, fecha, hora, precio);
                    MessageBox.Show("Función agregada con id " + nuevo);
                }

                CargarFunciones();
                RefrescarHoras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idFuncion <= 0)
            {
                MessageBox.Show("Selecciona una función de la lista para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Eliminar esta función?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                conexion conexion = new conexion();
                conexion.eliminarFuncion(idFuncion);
                MessageBox.Show("Función eliminada.");
                idFuncion = 0;
                button1.Text = "AGREGAR";
                CargarFunciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}
