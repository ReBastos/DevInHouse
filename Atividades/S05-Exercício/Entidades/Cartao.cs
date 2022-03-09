using System;

public enum FlagEnum
{
	Visa, MasterCard, Elo
}

public abstract class Cartao
{

	public string Name { get; set; }
	public string CardNumber { get; }
	public  string SecurityCode { get; }
	public DateOnly ExpireDate { get; }
	public FlagEnum Flag { get; }
	


 public Cartao(
	 string Name, 
	 string CardNumber, 
	 string SecurityCode, 
	 DateOnly ExpireDate, 
	 FlagEnum Flag
	 )

    {
		this.Name = Name;
		this.CardNumber = CardNumber;
		this.SecurityCode = SecurityCode;
		this.ExpireDate = ExpireDate;
		this.Flag = Flag;
		
    }

	public DateOnly ReturnExpireDate()
    {
		return ExpireDate;
    }

	

}


