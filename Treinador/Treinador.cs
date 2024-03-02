using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioNamspace;
using PokemonNamespace;

namespace TreinadorNamespace
{
    internal class TreinadorClass : UserClass
    {
        
        public List<PokemonClass> Lista_Pokemons { get; set; } = new List<PokemonClass>();    
       

        public void AddPokemonLista(PokemonClass pokemon) {
        
        Lista_Pokemons.Add(pokemon);
        }






    }
}

