using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_Exercício.Models
{
    internal class TransacoesPorCategoriaModel
    {

        public Categoria Categoria { get; set; }
        public List<Transacao> Transacoes { get; set; }


    }
}
