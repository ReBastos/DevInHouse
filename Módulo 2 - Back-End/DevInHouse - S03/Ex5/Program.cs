// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora calculo1 = new Calculadora();
calculo1.Valor1 = 2;
calculo1.Valor2 = 3;
calculo1.Operador = "+";
Console.WriteLine(calculo1.Calcular());

Calculadora calculo2 = new Calculadora();
calculo2.Valor1 = 2;
calculo2.Valor2 = 3;
calculo2.Operador = "-";
Console.WriteLine(calculo2.Calcular());

Calculadora calculo3 = new Calculadora();
calculo3.Valor1 = 2;
calculo3.Valor2 = 3;
calculo3.Operador = "*";
Console.WriteLine(calculo3.Calcular());

Calculadora calculo4 = new Calculadora();
calculo4.Valor1 = 3;
calculo4.Valor2 = 2;
calculo4.Operador = "/";
Console.WriteLine(calculo4.Calcular());