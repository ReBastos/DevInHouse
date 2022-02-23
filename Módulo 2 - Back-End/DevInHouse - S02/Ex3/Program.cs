// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome:");

string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");

string sobrenome = Console.ReadLine();

string nomeCompleto = $"Seu nome completo é: {nome} {sobrenome}";

Console.WriteLine(nomeCompleto);