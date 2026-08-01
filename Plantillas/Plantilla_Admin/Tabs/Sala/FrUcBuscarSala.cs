using Org.BouncyCastle.Crypto;
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

namespace Plantilla_Admin.Tabs.Sala
{
    public partial class FrUcBuscarSala : UserControl
    {
        private int idSala;
        public FrUcBuscarSala()
        {
            InitializeComponent();/*
            conexion conexion = new conexion();

            Cb_ciudad.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_ciudad.DataSource = conexion.mostrarCiudades();
            Cb_ciudad.ValueMember = "id_ciudad";
            Cb_ciudad.DisplayMember = "nombre_ciudad";

            Cb_cine.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_ciudad.SelectedIndexChanged += (s, e) => CargarCines();

            Cb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_estado.DataSource = conexion.mostrarTiposSala();
            Cb_estado.ValueMember = "id_tipo_sala";
            Cb_estado.DisplayMember = "nombre_tipo_sala";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            for (int i = 1; i <= 20; i++) comboBox1.Items.Add(i);
            comboBox1.SelectedIndex = 0;

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Clear();
            for (int i = 1; i <= 10; i++) comboBox2.Items.Add(i);
            comboBox2.SelectedIndex = 1;

            CargarCines();
            CargarSalas();

            idSala = 0;
            Btn_agregar.Text = "AGREGAR";
            */
        }
        /*
        private void CargarCines()
        {
            if (Cb_ciudad.SelectedValue == null) return;
            int idCiudad = Convert.ToInt32(Cb_ciudad.SelectedValue);

            conexion conexion = new conexion();
            Cb_cine.DataSource = conexion.mostrarCinesPorCiudad(idCiudad);
            Cb_cine.ValueMember = "id_cine";
            Cb_cine.DisplayMember = "nombre_cine";
        }

        private void CargarSalas()
        {
            conexion conexion = new conexion();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = conexion.mostrarSalas();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
        }

        private void LimpiarForm()
        {
            idSala = 0;
            Btn_agregar.Text = "AGREGAR";
            Txt_id.Clear();
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 1;
            if (Cb_estado.Items.Count > 0) Cb_estado.SelectedIndex = 0;
            if (Cb_ciudad.Items.Count > 0) Cb_ciudad.SelectedIndex = 0;
            CargarCines();
        }

        private void Btn_agregarNuevaCartelera_Click(object sender, EventArgs e)
        {
            CargarSalas();
            LimpiarForm();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) { MessageBox.Show("Selecciona el número de sala."); return; }
            if (comboBox2.SelectedItem == null) { MessageBox.Show("Selecciona las filas."); return; }
            if (Cb_estado.SelectedValue == null) { MessageBox.Show("Selecciona el tipo de sala."); return; }
            if (Cb_cine.SelectedValue == null) { MessageBox.Show("Selecciona el cine."); return; }

            int numero = Convert.ToInt32(comboBox1.SelectedItem);
            int filas = Convert.ToInt32(comboBox2.SelectedItem);
            int capacidad = filas * 10;

            if (capacidad < 20)
            {
                MessageBox.Show("La capacidad mínima es 20 (2 filas). Elige al menos 2 filas.");
                return;
            }

            int idTipoSala = Convert.ToInt32(Cb_estado.SelectedValue);
            int idCine = Convert.ToInt32(Cb_cine.SelectedValue);

            try
            {
                conexion conexion = new conexion();

                if (idSala > 0)
                {
                    conexion.actualizarSala(idSala, numero, capacidad, idTipoSala, idCine);
                    MessageBox.Show("Sala actualizada.");
                }
                else
                {
                    int nuevo = conexion.insertarSala(numero, capacidad, idTipoSala, idCine);
                    MessageBox.Show("Sala agregada con id " + nuevo);
                }

                CargarSalas();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idSala <= 0)
            {
                MessageBox.Show("Selecciona una sala de la lista para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Eliminar esta sala?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                conexion conexion = new conexion();
                conexion.eliminarSala(idSala);
                MessageBox.Show("Sala eliminada.");
                CargarSalas();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.CurrentRow == null) return;

            idSala = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            Btn_agregar.Text = "ACTUALIZAR";

            conexion conexion = new conexion();
            DataTable dt = conexion.obtenerSala(idSala);
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];

            Txt_id.Text = r["id_sala"].ToString();

            Cb_ciudad.SelectedValue = r["id_ciudad"];
            CargarCines();
            Cb_cine.SelectedValue = r["id_cine"];

            Cb_estado.SelectedValue = r["id_tipo_sala"];

            int numero = Convert.ToInt32(r["numero_sala"]);
            if (comboBox1.Items.Contains(numero)) comboBox1.SelectedItem = numero;

            int capacidad = Convert.ToInt32(r["capacidad_sala"]);
            int filas = capacidad / 10;
            if (comboBox2.Items.Contains(filas)) comboBox2.SelectedItem = filas;
        }
    */}
}
