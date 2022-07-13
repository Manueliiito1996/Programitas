namespace Calculadora_Turca
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblResultadoDolar.Text = "";
            txtDolares.Text = "0";
            txtLiras.Text = "0";
            lblResultadoLiras.Text = "";
        }

        private void btnLiras_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDolares.Text);
            double b = Convert.ToDouble(txtLiras.Text);

            double r = b * 0.058;

            lblResultadoLiras.Text = "Son  " + r.ToString() + " Dolares Americanos";
        }

        private void btnDolares_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtDolares.Text);
            double d = Convert.ToDouble(txtLiras.Text);

            double p = 17.32 * c;

            lblResultadoDolar.Text = "Son  " + p.ToString() + " Liras Turcas";
        }

        private void gboxDolares_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Marico el que lo lea");
        }
    }
}