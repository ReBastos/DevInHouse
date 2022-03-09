using System;

public class CartaoCredito : Cartao
{
	public double Limit { get; }


	public CartaoCredito(string Name,
	 string CardNumber,
	 string SecurityCode,
	 DateOnly ExpireDate,
	 FlagEnum Flag,
	 double Limit) : base(Name, CardNumber, SecurityCode, ExpireDate, Flag)
    {

		this.Limit = Limit;

    }

	public double ReturnLimit()
    {
		return Limit;
    }

}
