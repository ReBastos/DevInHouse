using System;


public class Transacao
{
	public string Description { get; private set; }
	public double Value { get; private set; }
	public DateOnly Data { get; private set; }
	public Categoria Category { get; private set; }

    public Transacao(string description, double value, DateOnly data, Categoria category)
    {
        Description = description;
        Value = value;
        Data = data;
        Category = category;
    }
}
