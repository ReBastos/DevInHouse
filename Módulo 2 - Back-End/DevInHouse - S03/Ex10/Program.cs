// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Animal animal1 = new Animal();
animal1.Name = "Mimis";
animal1.Type = "gato";

Animal animal2 = new Animal();
animal2.Name = "Sol";
animal2.Type = "cachorro";

Animal animal3 = new Animal();
animal3.Name = "Sol";
animal3.Type = "cachorro";


AnimalList lista = new AnimalList();
lista.adicionarAnimal(animal1);
lista.adicionarAnimal(animal2);
lista.adicionarAnimal(animal3);
lista.adicionarAnimal(animal2);

lista.contagemCachorros();