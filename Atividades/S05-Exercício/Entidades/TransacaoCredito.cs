using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_Exercício.Entidades
{
    public class TransacaoCredito : Transacao
    {

        public int NumeroParcelas { get; set; }

        public TransacaoCredito(string description, double value, 
            DateOnly data, Categoria category, int numeroParcelas) 
            : base(description, value, data, category)
        {
            NumeroParcelas = numeroParcelas;
        }


    }


}
