using System;

public class ContaPoupanca : Conta
{
	
	public double Percent { get; private set; }

    public ContaPoupanca(string description, string accountNumber, double saldoInicial,double percent) : 
        base(description, accountNumber, saldoInicial)
    {
        Percent = percent;
    }


    public override double CalcularSaldo(DateOnly data)
    {

        var saldo = base.CalcularSaldo(data);

        return saldo + (saldo * (Percent/100));

    }

}

