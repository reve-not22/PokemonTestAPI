using PokeAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace PokemonTestAPI
{
    internal class PokeClass
    {
        /// <summary>
        /// Class <c>PokeClass</c> creates a class that takes in data from the API and can evolve or devolve per user input
        /// </summary>
        public string Name { get; set; }
        public EvolutionChain EvChain { get; set; }
        public string NextNameInChain
        {
            /// <summary>
            /// returns the name of the next pokemon in the evolution chain
            /// </summary>
            get
            {
                ChainLink link = EvChain.Chain.EvolvesTo[0];
                for (var i = 0; i < 3; i++)
                {
                    if (EvChain.Chain.Species.Name == Name || link.EvolvesTo.Length == 0)
                    {
                        return link.Species.Name;
                    }
                    else
                    {
                        link = link.EvolvesTo[0];
                    }
                }

                return link.Species.Name; 
            } 
        }
        public PokeClass(string name, EvolutionChain evChain) 
        {
            this.Name = name;
            this.EvChain = evChain;
        }
    }
}
