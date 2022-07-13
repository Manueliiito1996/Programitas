using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form2 : Form
    {
        private string height;
        private string baseExperience;
        private string weight;
        private string namePokemon;
        private Image image;

        public Form2(string pMensaje)
        {
            InitializeComponent();
            lblCharacteristic.Text = pMensaje;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Image Image
        {
            set
            {
                image = value;
                pbImages.Image = image;
            }
        }

        public new string Height
        {
            set
            {
                height = value;
                lblHeight.Text = height;
            }
        }
        public string Weight
        {
            set
            {
                weight = value;
                lblWeight.Text = weight;
            }
        }
        public string BaseExperience
        {
            set
            {
                baseExperience = value;
                lblBaseExperience.Text = baseExperience;
            }
        }

        public string NamePokemon
        {
            set
            {
                namePokemon = value;
                lblNamePokemon.Text = namePokemon;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText("pokemon.json");
            //data = JObject.Parse(string json) as string;

            //cargaImagen();
        }
    }
}
