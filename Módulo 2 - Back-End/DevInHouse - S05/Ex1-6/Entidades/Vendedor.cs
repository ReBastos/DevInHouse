using System;

public class Vendedor : Operario
{
    public Vendedor(string nome, string endereco, string telefone, DateOnly nascimento, string identidade, int codigosetor, decimal salariobase, decimal imposto, decimal valorproducao, decimal comissao) : base(nome, endereco, telefone, nascimento, identidade, codigosetor, salariobase, imposto, valorproducao, comissao)
    {
    }
}
