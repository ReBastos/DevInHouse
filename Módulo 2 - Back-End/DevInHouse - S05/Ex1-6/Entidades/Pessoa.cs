using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_6.Entidades
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateOnly Nascimento { get; set; }
        public string Identidade { get; set; }

        public Pessoa(string nome, string endereco, string telefone, 
                        DateOnly nascimento, string identidade)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Nascimento = nascimento;
            Identidade = identidade;
        }
    }
}
