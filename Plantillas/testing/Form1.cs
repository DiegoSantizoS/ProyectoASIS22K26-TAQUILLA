namespace testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kryptonComboBox2.ClientSize = new Size(0, 50);
            kryptonComboBox3.GotFocus += kryptonComboBox3_GotFocus;
        }

        private void kryptonComboBox3_GotFocus(object sender, EventArgs e)
        {
            kryptonComboBox3.SelectionLength = 0;
        }
    }
}
