using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrUcMantenimientoCartelera : UserControl
    {
        public FrUcMantenimientoCartelera()
        {
            InitializeComponent();
            pictureBox2.Image = Properties.Resources.EjemploCartelera;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = Txt_trailer.Text.Trim();

            input = input.Split("v=")[1].Split("&")[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.LoadAsync($"https://img.youtube.com/vi/{input}/hqdefault.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string input = Txt_trailer.Text.Trim();

            input = input.Split("v=")[1].Split("&")[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=" + input,
                UseShellExecute = true
            });
        }
    }
}
