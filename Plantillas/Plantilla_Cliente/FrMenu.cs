using System.Drawing.Drawing2D;

//Carlos Andres Arriaza Lara 0901-23-13862
//Creación de prototipo de interfaz para menu de cliente
namespace Plantilla_Cliente
{
    public partial class FrMenu : Form
    {
        public FrMenu()
        {
            InitializeComponent();
        }
        private void funcargarpagina(UserControl pagina)
        {
            Pnl_Menu.Controls.Clear();

            pagina.Dock = DockStyle.Fill;
            Pnl_Menu.Controls.Add(pagina);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Cartelera_CambiaraReserva(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            funcargarpagina(reservas);
        }

        private void carteleraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cartelera cartelera = new Cartelera();

            cartelera.CambiaraReserva += Cartelera_CambiaraReserva;

            funcargarpagina(cartelera);
        }
    }
}

