using System;

public class Administrador : Empregado
{

    public decimal AjudaCusto { get; set; }
    
    
    public Administrador(string nome, string endereco, string telefone, DateOnly nascimento, 
        string identidade, int codigosetor, decimal salariobase, decimal imposto, decimal ajudadecusto) 
        : base(nome, endereco, telefone, nascimento, identidade, codigosetor, salariobase, imposto)
    {
        this.AjudaCusto = ajudadecusto;
    }

    public override decimal CalcularSalario()
    {
        return base.CalcularSalario() + AjudaCusto;
    }
}
