using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TipoNamespace;
using AtaqueNamespace;
using System.Reflection;

namespace PokemonNamespace
{
    internal class PokemonClass
    {
        public string Name { get; set; }
        public int Level { get; private set; }
        public TipoEnum Type { get; set; }
        public AtaquesClass Ataques { get; set; }

        public double Vida { get; protected set; }
        public double Defesa { get; protected set; }
        public double Ataque { get; protected set; }



        public PokemonClass() { }
        public PokemonClass(string name, int level, TipoEnum type, double vida, double ataque, double defesa)
        {

            Name = name;
            Level = level;
            Type = type;
            Vida = vida;
            Defesa = defesa;
            Ataque = ataque;
        }

        public List<AtaquesClass> ListaAtaques { get; set; }= new List<AtaquesClass>();


        public void  AddAtaqueLista(PokemonClass nameAtaque)
        {

            ListaAtaques.Add(nameAtaque);

        }

        


        public void  Atacar(AtaquesClass name)
        {
            if (Vida > 0)
            {
                if (name.Quantidade_ataques>0)
                {
                    Vida -= (name.Damage * Ataque)-(Defesa*1.6);
                    name.Quantidade_ataques--;
                }

               

            }
            


        }
        





        

       


            
        
        
        
        
        
        }

    public class AtaqueClass
    {
    }
}

