using Pokemon_console.Pokemon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoNamespace;

namespace AtaqueNamespace
{
    internal class AtaquesClass
    {

        public string Name{ get; set; }
        public double Damage {  get;  set; }
        public int Quantidade_ataques { get;  set; }

        public TipoEnum Type { get;  set; }
        public int Quantidade_ataque { get; internal set; }

        public AtaquesClass() { }
        public AtaquesClass(string name , double damage , int quantidade_ataques)
        {
            Name = name;
            Damage = damage;
            Quantidade_ataques = quantidade_ataques;


        }



    }
}
