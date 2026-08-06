using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Plantilla_Admin.Tabs
{
    public partial class FrUcMainDashboard : UserControl
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Rectangle lParam);

        private const int EM_SETRECT = 0x00B3;

        private static readonly string CarpetaPosters =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Peliculas");

        private readonly System.Windows.Forms.Timer _tmReloj = new();
        private readonly System.Windows.Forms.Timer _tmSlideshow = new();

        private PictureBox[] _cajas = Array.Empty<PictureBox>();
        private readonly List<string> _posters = new();
        private int _offset;

        public event EventHandler? VerCartelera;
        public event EventHandler? VerReportes;
        public event EventHandler? NecesitasAyuda;
        public event EventHandler? AgregarFunciones;

        public FrUcMainDashboard()
        {
            InitializeComponent();

            _cajas = new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            foreach (var caja in _cajas)
                caja.SizeMode = PictureBoxSizeMode.Zoom;

            WireBotones();
            InicializarReloj();
            InicializarSlideshow();
            CargarDatosImportantes();

            AplicarMargen();
            RcbDatosImportantes.Resize += (s, e) => AplicarMargen();

            Disposed += Limpiar;
        }

        private void AplicarMargen()
        {
            if (!RcbDatosImportantes.IsHandleCreated) return;

            Rectangle r = RcbDatosImportantes.ClientRectangle;
            r.Inflate(-14, -14);
            SendMessage(RcbDatosImportantes.Handle, EM_SETRECT, 0, ref r);
        }

        private void InicializarReloj()
        {
            ActualizarHora();
            _tmReloj.Interval = 1000;
            _tmReloj.Tick += (s, e) => ActualizarHora();
            _tmReloj.Start();
        }

        private void ActualizarHora()
        {
            DateTime ahora = DateTime.Now;
            LbBienvenida.Text = Saludo(ahora) + Sesion.Usuario;
            LbHora.Text = ahora.ToString("HH:mm:ss");
            LbMensajeDeUsuario.Text = ahora.ToString("dd/MM/yyyy");
        }

        private static string Saludo(DateTime h)
        {
            if (h.Hour < 12) return "Buenos días, ";
            if (h.Hour < 19) return "Buenas tardes, ";
            return "Buenas noches, ";
        }

        private void InicializarSlideshow()
        {
            CargarListaPosters();
            MostrarPosters();

            if (_posters.Count > 0)
            {
                _tmSlideshow.Interval = 3500;
                _tmSlideshow.Tick += (s, e) =>
                {
                    _offset = (_offset + 1) % _posters.Count;
                    MostrarPosters();
                };
                _tmSlideshow.Start();
            }
        }

        private void CargarListaPosters()
        {
            _posters.Clear();
            if (!Directory.Exists(CarpetaPosters)) return;

            foreach (string archivo in Directory.EnumerateFiles(CarpetaPosters))
            {
                string ext = Path.GetExtension(archivo).ToLowerInvariant();
                if (ext == ".png" || ext == ".jpg" || ext == ".jpeg")
                    _posters.Add(archivo);
            }
        }

        private void MostrarPosters()
        {
            if (_posters.Count == 0) return;

            for (int i = 0; i < _cajas.Length; i++)
            {
                PictureBox caja = _cajas[i];
                caja.Image?.Dispose();
                string ruta = _posters[(_offset + i) % _posters.Count];
                caja.Image = CargarImagen(ruta);
            }
        }

        private static Image? CargarImagen(string ruta)
        {
            try
            {
                using var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                using var temp = Image.FromStream(fs);
                return new Bitmap(temp);
            }
            catch
            {
                return null;
            }
        }

        private void CargarDatosImportantes()
        {
            var rtb = RcbDatosImportantes;
            rtb.Clear();

            rtb.SelectionColor = Color.Crimson;
            rtb.SelectionFont = new Font("Segoe UI", 13F, FontStyle.Bold);
            rtb.SelectionColor = Color.FromArgb(230, 230, 230);
            rtb.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtb.AppendText(Sesion.Descripcion() + "\n");
            rtb.AppendText("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n");
            rtb.AppendText("Pósters en cartelera: " + _posters.Count + "\n\n");
            rtb.AppendText("• Revisa las funciones del día en «Ver Cartelera».\n");
            rtb.AppendText("• Consulta los ingresos en «Ver Reportes».\n");
            rtb.AppendText("• Agrega nuevas funciones con «Agregar Funciones».\n");

            rtb.SelectionStart = 0;
            rtb.ScrollToCaret();
        }

        private void WireBotones()
        {
            BtnVerCartelera.Click += (s, e) => VerCartelera?.Invoke(this, EventArgs.Empty);
            BtnVerReporte.Click += (s, e) => VerReportes?.Invoke(this, EventArgs.Empty);
            BtnNecesitasAyuda.Click += (s, e) => NecesitasAyuda?.Invoke(this, EventArgs.Empty);
            BtnAgregarFunciones.Click += (s, e) => AgregarFunciones?.Invoke(this, EventArgs.Empty);
        }

        private void Limpiar(object? sender, EventArgs e)
        {
            _tmReloj.Stop();
            _tmReloj.Dispose();
            _tmSlideshow.Stop();
            _tmSlideshow.Dispose();

            foreach (var caja in _cajas)
                caja.Image?.Dispose();
        }
    }
}