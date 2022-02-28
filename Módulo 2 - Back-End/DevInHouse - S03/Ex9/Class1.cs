using System;

public class Animal
{
	private string _name;
    private string _type;

	public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Type
    {
        get { return _type; }

        set {
            if(value == "cachorro" || value == "peixe" || value == "gato")
            {
                _type = value;
            } else
            {
                Console.WriteLine("Tipo inválido");
            }
           
             }
    }

    public void VerificarTipo(string tipo)
    {
        if(tipo == _type)
        {
            Console.WriteLine($"O animais é um {tipo}");
        } else
        {
            Console.WriteLine($"O animais não é um {tipo}");
        }
    }
}


public class AnimalList
{
    private List<Animal> _lista;

    public void adicionarAnimal(Animal animal)
    {
        if (_lista == null)
        {
            _lista = new List<Animal>();
        }

        _lista.Add(animal); 
    }

    public void contagemCachorros()
    {
        int count = 0;

        foreach(Animal animal in _lista)
        {
            if(animal.Type == "cachorro")
            {
                count++;
            }
        }

        Console.WriteLine($"Número de cachorros: {count}");
    }

}