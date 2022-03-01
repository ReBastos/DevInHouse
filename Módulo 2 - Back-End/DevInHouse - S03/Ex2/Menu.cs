using System;

public class Menu
{
	private string _plate;
	private List<String> _ingridients;
	private double _price;
	
		public string Plate
    {
		get { return _plate; }
		set { _plate = value; }
    }

	public void addIngridient(string value)
    {
		if(_ingridients == null)
        {
			_ingridients = new List<String>();
        }

		_ingridients.Add(value);
    }

	public void showIngridients()
    {
		Console.WriteLine("Ingredientes:");
		foreach(String ingridient in _ingridients)
        {
			Console.WriteLine($"-{ingridient}");
        }
    }

	public double Price
    {
		get { return _price; }
		set { _price = value; }
    }

	public void Informations()
	{
		Console.WriteLine($"Nome do Prato: {_plate}");
		Console.WriteLine($"Preço: R${_price.ToString("F")}");
		showIngridients();
		
	}
}
