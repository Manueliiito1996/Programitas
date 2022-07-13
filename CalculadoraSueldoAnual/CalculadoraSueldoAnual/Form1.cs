namespace CalculadoraSueldoAnual
{
    public partial class Form1 : Form
    {
          

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSueldoSemanal.Text = "";
            lblSueldoMensual.Text = "";
            lblSueldoAnual.Text = "";
            txtDiasLibres.Text = "0";
            txtHorasDeTrabajo.Text = "0";
            txtSueldoPorHora.Text = "0";

        }

        private void btnCalcularSueldoSemanal_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtHorasDeTrabajo.Text);
            double b = Convert.ToDouble(txtDiasLibres.Text);
            double c = Convert.ToDouble(txtSueldoPorHora.Text);

            double r = c * a * b;
            
            lblSueldoSemanal.Text = r.ToString() + "$ a la semana";
        }

        private void btnCalcularSueldoMensual_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtHorasDeTrabajo.Text);
            double b = Convert.ToDouble(txtDiasLibres.Text);
            double c = Convert.ToDouble(txtSueldoPorHora.Text);

            double r = c * a * b;
            double p = r * 4;

            lblSueldoMensual.Text = p.ToString() + "$ al Mes";
        }

        private void btnCalcularSueldoAnual_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtHorasDeTrabajo.Text);
            double b = Convert.ToDouble(txtDiasLibres.Text);
            double c = Convert.ToDouble(txtSueldoPorHora.Text);

            double r = c * a * b;
            double p = r * 4;
            double t = p * 12;

            lblSueldoAnual.Text = t.ToString() + "$ Anualmente";
        }

        private void btnCalcularTodo_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtHorasDeTrabajo.Text);
            double b = Convert.ToDouble(txtDiasLibres.Text);
            double c = Convert.ToDouble(txtSueldoPorHora.Text);

            double r = c * a * b;
            double p = r * 4;
            double t = p * 12;

            lblSueldoAnual.Text = t.ToString() + "$ Anualmente dando Culito";

            lblSueldoMensual.Text = p.ToString() + "$ al Mes dando culito";

            lblSueldoSemanal.Text = r.ToString() + "$ a la semana dando culito";

            lblCulo.Text = "Excelente forma de conseguir dinero facil";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}