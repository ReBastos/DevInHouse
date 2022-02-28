// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Item item1 = new Item();
item1.Name = "arroz";
item1.Value = 1.50;

Item item2 = new Item();
item2.Name = "feijao";
item2.Value = 3.50;


Pedido pedido1 = new Pedido();
pedido1.ListaItens(item1);
pedido1.ListaItens(item2);

pedido1.MostrarLista();
pedido1.TamanhoLista();