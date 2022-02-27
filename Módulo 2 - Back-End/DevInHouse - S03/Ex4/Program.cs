// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Renato";
pessoa1.Idade = 26;

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Felipe";
pessoa2.Idade = 16;

Pessoa pessoa3 = new Pessoa();
pessoa3.Nome = "Felipe";
pessoa3.Idade = 17;

Console.WriteLine(Pessoa.MaiorIdade(pessoa1, pessoa2, pessoa3));