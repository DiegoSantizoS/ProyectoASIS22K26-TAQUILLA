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

            Cartelera cartelera = new Cartelera();
            cartelera.CambiaraReserva += CargarPanelReserva;

            CargarPanel(cartelera);
        }
        /* Inicio de Codigo de Carlos Andres Arriaza Lara en la fecha de: 20/07/2026 */
        private void CargarPanel(UserControl pagina)
        {
            Pnl_Menu.Controls.Clear();

            pagina.Dock = DockStyle.Fill;
            Pnl_Menu.Controls.Add(pagina);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarPanelReserva(int idPelicula, int idCiudad)
        {
            Reservas reservas = new Reservas(idPelicula, idCiudad);
            CargarPanel(reservas);
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            CargarPanel(reservas);
        }
    }
    /* Final de Codigo de Carlos Andres Arriaza Lara en la fecha de: 20/07/2026 */
}

