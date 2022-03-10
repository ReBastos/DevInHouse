using S05_Exercício.Entidades;
using S05_Exercício.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_Exercício.Interface
{
    internal interface IMovimentacao
    {

        public void AdicionarConta(Conta conta);

        public void AdicionarTransacao(string accountNumber, Transacao transacao);

        public double RetornarSaldo(string accountNumber, DateOnly data);

        public double RetornarTotalDespesas(string accountNumber, DateOnly date);

        public double RetornarTotalReceitas(string accountNumber, DateOnly date);

        public double RetornarSaldoInicial(string accountNumber);


        public void AdicionarCartaoCredito(CartaoCredito cartao);

        public void AdicionarTransacaoCredito(string cardNumber, TransacaoCredito transacao);

        public double RetornarSaldoCartaoCredito(string cardNumber, DateOnly date);

    }
}
