using PokeAPI;
using System;

namespace PokemonTestAPI
{
    internal class PokeClass_Broad : PokeClass
    {
        /// <summary>
        /// Class <c>PokeClass_Broad</c> creates a class that has expanded functions from pokeclass
        /// </summary>
        public string CaptureRate { get; set; }
        public string GrowthRate { get; set; }
        public string FlavorText { get; set; }
        public string EggGroup { get; set; }
        public string Habitat { get; set; }

        public PokeClass_Broad(string name, EvolutionChain chain, PokemonSpeciesFlavorText[] flavorTexts, string habitat) : base(name, chain) 
        {
            /// <summary>
            /// Creates a pokeclass that assigns a random flavor text and expands the classes attributes
            /// </summary>
            Random r = new Random();
            FlavorText = flavorTexts[r.Next(Convert.ToInt32(flavorTexts.Length - 1))].FlavorText;
            if (habitat == null)
            {
                this.Habitat = "None";
            }
            else
            {
                this.Habitat = habitat;
            }
        }
        public PokeClass_Broad(string name, EvolutionChain chain, string captureRate, string growthRate, PokemonSpeciesFlavorText[] flavorTexts, string habitatName, NamedApiResource<EggGroup>[] eggGroups) : base(name, chain)
        {
            /// <summary>
            /// Expands attributes further by adding egg groups, capture rate, and growth rate
            /// </summary>
            this.CaptureRate = captureRate;
            this.GrowthRate = growthRate;
            Random r = new Random();
            FlavorText = flavorTexts[r.Next(Convert.ToInt32(flavorTexts.Length - 1))].FlavorText;
            if (habitatName == null)
            {
                this.Habitat = "None";
            }
            else
            {
                this.Habitat = habitatName;
            }
            EggGroup = eggGroups[0].Name;
        }
    }
}
