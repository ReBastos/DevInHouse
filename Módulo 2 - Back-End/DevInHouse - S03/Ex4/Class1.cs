using System;

public class Pessoa
{
	private string _nome;
	private int _idade;

	public string Nome
    {
		get { return _nome; }
		set { _nome = value; }
    }

	public int Idade
    {
		get { return _idade; }
		set { _idade = value; }
    }

	public string ExibirDados()
    {
		return $"Nome: {_nome}; \n Idade: {_idade}";
    }

	public static string MaiorIdade(Pessoa pessoa1, Pessoa pessoa2, Pessoa pessoa3)
    {

		if (pessoa1.Idade > pessoa2.Idade && pessoa1.Idade > pessoa3.Idade) { return $"{pessoa1.Nome} é o mais velho"; }

		else if (pessoa2.Idade > pessoa1.Idade && pessoa2.Idade > pessoa3.Idade) { return $"{pessoa2.Nome} é o mais velho"; }

		else if (pessoa3.Idade > pessoa2.Idade && pessoa3.Idade > pessoa1.Idade) { return $"{pessoa3.Nome} é o mais velho"; }

		else
        {
			return null;
        }


	}

}
