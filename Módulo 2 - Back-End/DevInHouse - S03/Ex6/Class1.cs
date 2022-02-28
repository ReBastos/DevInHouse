using System;

public class Item
{
	private string _name;
	private double _value;

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
}

public class Pedido
{
	private string _date;
	private List<Item> _itens;

	public void ListaItens(Item item)
    {
		if (_itens == null)
        {
			_itens = new List<Item>();
        }

		_itens.Add(item);

    }

	public void MostrarLista()
    {

        double totalPedido = 0;

		foreach(Item item in _itens)
        {
			totalPedido = totalPedido + item.Value;
        }
		Console.WriteLine($"Total do Pedido: R${totalPedido}");
	}

	public void TamanhoLista()
    {
		int numeroItens = 0;

		foreach (Item item in _itens)
		{
			numeroItens = numeroItens + 1;
		}
		Console.WriteLine($"Total Itens: {numeroItens}");
	}

	private string Date
    {
		get { return _date; }
		set { _date = value; }
    }

}
