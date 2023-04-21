using PokeAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PokemonTestAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                PokemonSpecies p = await DataFetcher.GetNamedApiObject<PokemonSpecies>(txt_Species.Text);
                listBox1.Items.Add("Base Happiness: " + p.BaseHappiness);
                listBox1.Items.Add("Capture Rate: " + p.CaptureRate);
                if (p.Habitat != null)
                {
                    listBox1.Items.Add("Habitat: " + p.Habitat.Name);
                }

                listBox1.Items.Add("Growth Rate: " + p.GrowthRate.Name);
                listBox1.Items.Add("Flavor Text: " + p.FlavorTexts[0].FlavorText);
                listBox1.Items.Add("Egg Group: " + p.EggGroups[0].Name);
            }
            catch
            {
                MessageBox.Show("Please input an appropriate string.");
            }
        }
    }
}
