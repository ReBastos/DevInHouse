using System;

public enum TypeEnum {
	Receita, Despesa
}


public class Categoria
{
	
	public string Description { get; }
	public TypeEnum Type { get; set; }

    public Categoria(string description, TypeEnum type)
    {
        Description = description;
        Type = type;
    }
}
