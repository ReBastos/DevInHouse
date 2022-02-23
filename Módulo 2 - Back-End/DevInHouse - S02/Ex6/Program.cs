Console.WriteLine("Digite o seu nome");

string nome = Console.ReadLine();

string invertido = new string(nome.Reverse().ToArray());

Console.WriteLine(invertido);

Console.WriteLine($"Tamanho da string: {invertido.Length}");
