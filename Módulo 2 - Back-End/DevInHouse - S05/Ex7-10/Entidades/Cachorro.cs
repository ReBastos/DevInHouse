using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_10.Entidades
{
    public  class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, AndarEnum andar) : base(nome, idade, andar)
        {
        }

        public override string Som()
        {
            return "Latido";
        }
    }
}
