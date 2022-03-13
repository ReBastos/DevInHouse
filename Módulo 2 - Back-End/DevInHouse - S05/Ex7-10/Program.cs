// See https://aka.ms/new-console-template for more information

using Ex7_10.Entidades;

Cachorro cachorro1 = new Cachorro("Rex", 7, AndarEnum.Correr);

Cavalo cavalo1 = new Cavalo("Spirit", 8, AndarEnum.Correr);

Preguica preguica1 = new Preguica("Sono", 3, AndarEnum.Subir);

void EmitirSom(Animal animal)
{
    Console.WriteLine(animal.Som());
}

EmitirSom(cachorro1);


Veterinario.Examinar(cachorro1);

Veterinario.Examinar(cavalo1);

Veterinario.Examinar(preguica1);

Zoologico zoologico1 = new Zoologico();
zoologico1.AdicionarAnimal(cachorro1);
zoologico1.AdicionarAnimal(cavalo1);
zoologico1.AdicionarAnimal(preguica1);

zoologico1.PercorrerJaula();