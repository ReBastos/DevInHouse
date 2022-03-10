using System;

public class CartaoAlimentacao : Cartao {

	public DateOnly RechargeDate { get; }
	public double RechargeValue { get; }

	public List<Transacao> ListaTransacoes;

	public void AdicionarTransacao(Transacao transacao)
	{
		if (ListaTransacoes == null)
		{
			ListaTransacoes = new List<Transacao>();
		}

		ListaTransacoes.Add(transacao);
	}

	public CartaoAlimentacao(string Name,
	 string CardNumber,
	 string SecurityCode,
	 DateOnly ExpireDate,
	 FlagEnum Flag,
	 DateOnly RechargeDate,
	 double RechargeValue) : base(Name, CardNumber, SecurityCode, ExpireDate, Flag)
    {

		this.RechargeDate = RechargeDate;
		this.RechargeValue = RechargeValue;
				
	}

	public DateOnly ReturnRechargeDate()
    {
		return RechargeDate;
    }

	public double ReturnRechargeValue()
	{
		return RechargeValue;
	}

}
