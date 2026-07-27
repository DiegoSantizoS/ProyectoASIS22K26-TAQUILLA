using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
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
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void Btn_cambiarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Imágenes |*.png;*.jpg;*.jpeg";
                upload.Title = "Selecciona una imagen";
                upload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (upload.ShowDialog() != DialogResult.OK)
                    return;
                string filePath = upload.FileName;
                pictureBox2.Image = Image.FromFile(filePath);
            }
        }
    }
}
