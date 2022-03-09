using System;

public class Movimentacao
{

	public List<Conta> ListaConta;
    

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

    public double RetornarSaldo(string accountNumber, DateOnly data)
    {
        var conta = ListaConta.FirstOrDefault(conta => conta.AccountNumber == accountNumber);

        return conta.CalcularSaldo(data);

    } 




}
