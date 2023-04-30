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
        PokeClass_Broad CurrentPokemon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeCurrentPokemon(txt_Species.Text);
        }

        private void btn_Evolve_Click(object sender, EventArgs e)
        {
            try
            {
                string nextEvolveName = CurrentPokemon.NextNameInChain;
                if (nextEvolveName != CurrentPokemon.Name)
                {
                    ChangeCurrentPokemon(nextEvolveName);
                }
                else
                {
                    MessageBox.Show("The current pokemon is at max evolution.");
                }
            }
            catch
            {
                MessageBox.Show("There must be a valid pokemon to evolve.");
            }
                
        }

        private async void ChangeCurrentPokemon(string Name)
        {
            listBox1.Items.Clear();
            try
            {
                PokemonSpecies p = await DataFetcher.GetNamedApiObject<PokemonSpecies>(Name);
                EvolutionChain EvChain = await DataFetcher.GetApiObject<EvolutionChain>(p.EvolutionChain.Url);
                CurrentPokemon = new PokeClass_Broad(p.Name, EvChain, p.CaptureRate.ToString(), p.GrowthRate.Name, p.FlavorTexts, p.Habitat.Name, p.EggGroups);

                listBox1.Items.Add("Base Happiness: " + CurrentPokemon.Name);
                listBox1.Items.Add("Capture Rate: " + CurrentPokemon.CaptureRate);
                listBox1.Items.Add("Growth Rate: " + CurrentPokemon.GrowthRate);
                listBox1.Items.Add("Flavor Text: " + CurrentPokemon.FlavorText);
                listBox1.Items.Add("Egg Group: " + CurrentPokemon.EggGroup);
                listBox1.Items.Add("Habitat: " + CurrentPokemon.Habitat);
            }
            catch
            {
                MessageBox.Show("Please input a pokemon species in lowercase format.");
            }
        }
    }
}
