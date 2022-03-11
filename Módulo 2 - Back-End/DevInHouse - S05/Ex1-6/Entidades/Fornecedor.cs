using Ex1_6.Entidades;
using System;

public class Fornecedor : Pessoa
{

	public decimal valorCredito { get; set; }

	public decimal valorDivida { get; set; }


	public decimal valorSaldo()
    {
		return valorCredito - valorDivida;
    }

    public Fornecedor(string nome, string endereco, string telefone, DateOnly nascimento, string identidade, decimal valorcredito,decimal valordivida) 
		: base (nome, endereco, telefone, nascimento, identidade)
    {
        this.valorCredito = valorcredito;
        this.valorDivida = valordivida;
    }
}
