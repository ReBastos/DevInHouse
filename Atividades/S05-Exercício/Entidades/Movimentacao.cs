using S05_Exercício.Entidades;
using S05_Exercício.Interface;
using S05_Exercício.Models;
using System;

public class Movimentacao : IMovimentacao
{

	public List<Conta> ListaConta;

    public List<CartaoCredito> ListaCartaoCredito;

    public void AdicionarCartaoCredito(CartaoCredito cartao)
    {
        if(ListaCartaoCredito == null)
        {
            ListaCartaoCredito = new List<CartaoCredito>();
        }

        ListaCartaoCredito.Add(cartao);
    }

    public void AdicionarConta(Conta conta)
    {
        if (ListaConta == null)
        {
            ListaConta = new List<Conta>();
        }

        ListaConta.Add(conta);
    }

    public void AdicionarTransacao(string accountNumber, Transacao transacao)
    {

       var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        conta.AdicionarTransacao(transacao);
        
    }

    public void AdicionarTransacaoCredito(string cardNumber, TransacaoCredito transacao)
    {
        var cartaoCredtio = ListaCartaoCredito.FirstOrDefault(conta => conta.CardNumber == cardNumber);


    }

    public double RetornarSaldo(string accountNumber, DateOnly data)
    {
        var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        return conta.CalcularSaldo(data);

    }

    public double RetornarSaldoCartaoCredito(string cardNumber, DateOnly date)
    {
        
    }

    public double RetornarSaldoInicial(string accountNumber)
    {
        var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        return conta.SaldoInicial;
    }

    public double RetornarTotalDespesas(string accountNumber, DateOnly date)
    {
        var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        var transacoes = conta._ListaTransacoes.Where(trans => trans.Data <= date)
                                                .Where(transacao => transacao.Category.Type == TypeEnum.Despesa)
                                                .Sum(trans => trans.Value);

        return transacoes;
    }

    public double RetornarTotalReceitas(string accountNumber, DateOnly date)
    {
        var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        var transacoes = conta._ListaTransacoes.Where(trans => trans.Data <= date)
                                                .Where(transacao => transacao.Category.Type == TypeEnum.Receita)
                                                .Sum(trans => trans.Value);

        return transacoes;

    }

    public void RetornarTransacoesCategorias(string accountNumber, DateOnly date)
    {

        var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        var transacoesDespesas = conta._ListaTransacoes.Where(trans => trans.Data == date)
                                                .Where(transacao => transacao.Category.Type == TypeEnum.Despesa);                                              ;

        Console.WriteLine("Despesas:");
        foreach(var transacao in transacoesDespesas)
        {
            Console.WriteLine($"Descrição: {transacao.Description}, Valor: {transacao.Value};");
        }

        var transacoesReceitas = conta._ListaTransacoes.Where(trans => trans.Data == date)
                                                .Where(transacao => transacao.Category.Type == TypeEnum.Receita); 

        Console.WriteLine("Receitas:");
        foreach (var transacao in transacoesReceitas)
        {
            Console.WriteLine($"Descrição: {transacao.Description}, Valor: {transacao.Value};");
        }


    }

    



}

