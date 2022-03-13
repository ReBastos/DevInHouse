using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum AndarEnum
{
    Correr, Subir
}

namespace Ex7_10.Entidades
{
    public abstract class Animal
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public AndarEnum Andar { get; set; }

        protected Animal(string nome, int idade, AndarEnum andar)
        {
            Nome = nome;
            Idade = idade;
            Andar = andar;
        }

        public abstract string Som();


        
        

    }
}
