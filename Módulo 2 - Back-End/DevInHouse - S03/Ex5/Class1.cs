using System;

public class Calculadora
{
	private double _valor1;
	private double _valor2;
	private string _operador;

	public double Valor1
    {
		get { return _valor1; }
		set { _valor1 = value; }
    }

	public double Valor2
    {
		get { return _valor2; }
		set { _valor2 = value; }
    }

	public string Operador
    {
		get { return _operador; }
		set { _operador = value; }
    }

	public string Calcular()
    {
		if (_operador == "+")
        {
			return $"Soma: {_valor1 + _valor2}";

        } else if (_operador == "-")
		{
			return $"Subtração: {_valor1 - _valor2}";

		} else if (_operador == "*")
		{
			return $"Multiplicação: {_valor1 * _valor2}";

		}
		else if (_operador == "/")
		{
			return $"Divisão: {_valor1 / _valor2}";

		} else
        {
			return "Operador Inválido";
        }

	}
}
