using Ex1_6.Entidades;
using System;

public class Empregado : Pessoa
{

    public int CodigoSetor { get; set; }
    public decimal SalarioBase { get; set; }
    public decimal Imposto { get; set; }

    public Empregado(string nome, string endereco, string telefone, DateOnly nascimento, string identidade
        , int codigosetor, decimal salariobase, decimal imposto) 
        : base(nome, endereco, telefone, nascimento, identidade)
    {

        this.CodigoSetor = codigosetor;
        this.SalarioBase = salariobase;
        this.Imposto = imposto;

    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase - (SalarioBase * (Imposto / 100));
    }
}
