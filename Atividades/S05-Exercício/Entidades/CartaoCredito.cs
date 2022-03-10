using S05_Exercício.Entidades;
using System;

public class CartaoCredito : Cartao
{
	public double Limit { get; set; }
	public List<TransacaoCredito> ListaTransacoesCredito;


	public void AdicionarTransacaoCredito(TransacaoCredito transacao)
    {
		if(ListaTransacoesCredito == null)
        {
			ListaTransacoesCredito = new List<TransacaoCredito>();
        }

		ListaTransacoesCredito.Add(transacao);
    }


	public CartaoCredito(string Name,
	 string CardNumber,
	 string SecurityCode,
	 DateOnly ExpireDate,
	 FlagEnum Flag,
	 double Limit) : base(Name, CardNumber, SecurityCode, ExpireDate, Flag)
    {

		this.Limit = Limit;

    }

	public override double CalcularSaldo(DateOnly date)
    {

		return ListaTransacoesCredito.Where(trans => trans.Data <= date)
												.Sum(trans => trans.Value);

		
	}

	public double ReturnLimit()
    {
		return Limit;
    }

}
