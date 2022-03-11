// See https://aka.ms/new-console-template for more information

Fornecedor fornecedor1 = new Fornecedor("Paulo", "Avenida", "3241", new DateOnly(1990, 03, 30), "0014", 300, 27);

Console.WriteLine(fornecedor1.valorSaldo());


Empregado empregado1 = new Empregado("Paulo", "Avenida", "3241", new DateOnly(1990, 03, 30), "0014", 12, 1456, 15);

Console.WriteLine(empregado1.CalcularSalario());


Administrador administrador1 = new Administrador("Paulo", "Avenida", "3241", new DateOnly(1990, 03, 30), "0014", 12, 5456, 15, 560);

Console.WriteLine(administrador1.CalcularSalario());


Operario operario1 = new Operario("Paulo", "Avenida", "3241", new DateOnly(1990, 03, 30), "0014", 12, 1456, 15, 200, 10);

Console.WriteLine(operario1.CalcularSalario());


Vendedor vendedor1 = new Vendedor("Paulo", "Avenida", "3241", new DateOnly(1990, 03, 30), "0014", 12, 1456, 15, 300, 10);

Console.WriteLine(vendedor1.CalcularSalario());