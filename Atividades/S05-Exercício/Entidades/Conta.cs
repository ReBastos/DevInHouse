using System;

public class Conta
{
	
	public string Description { get; private set; }
	public string AccountNumber { get; private set; }
	public double SaldoInicial { get; private set; }

	public List<Transacao> _ListaTransacoes;


	public void AdicionarTransacao(Transacao transacao) {

		if (_ListaTransacoes == null)
		{
			_ListaTransacoes = new List<Transacao>();
		} 
        
		_ListaTransacoes.Add(transacao);
        
	}

    public Conta(string description, string accountNumber, double saldoInicial)
    {
        Description = description;
        AccountNumber = accountNumber;
        SaldoInicial = saldoInicial;
    }

    public virtual double CalcularSaldo(DateOnly data)
    {

        var transacoes = _ListaTransacoes.Where(trans => trans.Data <= data);

        return SaldoInicial +
            transacoes.Where(trans => trans.Category.Type == TypeEnum.Receita).Sum(trans => trans.Value) -
            transacoes.Where(trans => trans.Category.Type == TypeEnum.Despesa).Sum(trans => trans.Value);
    }
}
