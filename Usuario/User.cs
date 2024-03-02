using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonNamespace;

namespace UsuarioNamspace
{
    internal class UserClass
    {
   
        public string Name { get; set; }
        public string Nick { get; set; }
        public int Idade { get; set; }
        public string Regiao { get; set; }

        public UserClass() { }
        public UserClass(string name, string nick, int idade, string regiao)
        {
            Name = name;
            Nick = nick;
            Idade = idade;
            Regiao = regiao;
        }
    }
}
