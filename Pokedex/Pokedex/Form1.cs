using Newtonsoft.Json.Linq;

namespace Pokedex
{
    
    public partial class Form1 : Form
    {
        Form2 miForma2 = new Form2("Detalles del Pokemon");

        public Form1()
        {
            InitializeComponent();
        }
        private Point mouseLoc;
        private int idPokemon = 1;
        private JObject data;
        private void pboxPokedex_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;
        }

        private void pboxPokedex_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                dx += this.Location.X;
                dy += this.Location.Y;
                this.Location = new Point(dx, dy);
            }
        }

        private void cargaImagen()
        {
            string file = idPokemon.ToString("000");
            string pfile = $"images\\{file}.png";

            pictureBox1.Image = Image.FromFile(pfile);

            string id = idPokemon.ToString();

            string nombre =
                data?["pokemon"]?[id]?["N"]?.Value<string>() ?? "";

            label1.Text = nombre;
            label2.Text = id;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pboxPokedex;
            label1.BackColor = System.Drawing.Color.Transparent;

            
            string text = File.ReadAllText("pokemon.json");
            data = JObject.Parse(text);
            
            cargaImagen();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (idPokemon < 800)
            {
                idPokemon++;
                cargaImagen();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idPokemon > 1)
            {
                idPokemon--;
                cargaImagen();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pboxPokedex_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idPokemon < 800)
            {
                idPokemon+=(10);
                cargaImagen();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idPokemon > 10)
            {
                idPokemon-=10;
                cargaImagen();

            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Crear la instancia de la forma 2 
            //Form2 miForma2 = new Form2(txtMensaje.Text);

            miForma2.NamePokemon = label1.Text;
            //miForma2.BaseExperience
            miForma2.Image = pictureBox1.Image;

            MessageBox.Show("Este pokemon hace de toa verga", "Caracteristicas", MessageBoxButtons.OK);
            
            
            cargaImagen();

            // Mostrar la forma
            miForma2.ShowDialog();
        }
    }
    
}