// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Aluno aluno1 = new Aluno();
aluno1.Name = "Renato";
aluno1.Nota = 9;

Aluno aluno2 = new Aluno();
aluno2.Name = "Ricardo";
aluno2.Nota = 8;

Aluno aluno3 = new Aluno();
aluno3.Name = "Felipe";
aluno3.Nota = 10;

Exame prova1 = new Exame();

prova1.adicionarAlunos(aluno1);
prova1.adicionarAlunos(aluno2);
prova1.adicionarAlunos(aluno3);

prova1.maiorNota();
prova1.menorNota();