using System;

public class Produto
{
	private string _name;
	private double _value;
	private int discount;

	public string Name
    {
		get { return _name; }
		set { _name = value; }
    }

	public double Value
    {
		get { return _value; }
		set { _value = value; }
    }

	public int Discount
    {
		get { return discount; }
		set { discount = value; }
    }
}
