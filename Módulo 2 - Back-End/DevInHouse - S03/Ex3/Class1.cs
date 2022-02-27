using System;

public class Geometric
{
	public double _base;
	public double _height;

	public double Base
    {
		get { return _base; }
		set { _base = value; }
    }

	public double Height
    {
		get { return _height; }
		set { _height = value; }
    }


}

public class Triangle : Geometric
{
	public string Area()
    {
		return $"Área do triangulo: {(_base * _height) / 2}";
    }
}

public class Square : Geometric
{
	public string Area()
    {
		return $"Área do quadrado: {_base * _height}";

	}
}