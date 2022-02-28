using System;


public class Aluno
{
	private string _name;
	private double _nota;

	public string Name
    {
		get { return _name; }
		set { _name = value; }
    }

	public double Nota
    {
		get { return _nota; }
		set { _nota = value; }
    }

}


public class Exame
{
	private List<Aluno> _alunos;


	public void adicionarAlunos(Aluno aluno)
    {
		if(_alunos == null)
        {
			_alunos = new List<Aluno>();
        }

		_alunos.Add(aluno);
    }

	public void maiorNota()
    {
		double maiornota = 0;
		string nomeAluno = "";
		foreach(Aluno aluno in _alunos)
        {
			if(aluno.Nota > maiornota)
            {
				maiornota = aluno.Nota;
				nomeAluno = aluno.Name;
            }

        }

		Console.WriteLine($"Aluno com maior nota: {nomeAluno}, {maiornota}");
    }

	public void menorNota()
	{
		double menornota = 99;
		string nomeAluno = "";
		foreach (Aluno aluno in _alunos)
		{
			if (aluno.Nota < menornota)
			{
				menornota = aluno.Nota;
				nomeAluno = aluno.Name;
			}

		}

		Console.WriteLine($"Aluno com menor nota: {nomeAluno}, {menornota}");
	}


}
