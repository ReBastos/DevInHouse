using System;

public class Operario : Empregado
{

    public decimal ValorProducao { get; set; }
    public decimal Comissao { get; set; }


    public Operario(string nome, string endereco, string telefone, DateOnly nascimento, 
        string identidade, int codigosetor, decimal salariobase, decimal imposto, decimal valorproducao, decimal comissao) 
        : base(nome, endereco, telefone, nascimento, identidade, codigosetor, salariobase, imposto)
    {
        this.ValorProducao = valorproducao;
        this.Comissao = comissao;
    }

    public override decimal CalcularSalario()
    {
        return base.CalcularSalario() + (ValorProducao * (Comissao / 100));
    }


}
