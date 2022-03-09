// See https://aka.ms/new-console-template for more information

Conta conta1 = new Conta("qlqr coisa", "123", 0.0);

Categoria categoria1 = new Categoria("ashd", TypeEnum.Receita);

Transacao transacao1 = new Transacao("pagamento", 105.00, new DateOnly(2022, 03, 08), categoria1);

Movimentacao movimentacao1 = new Movimentacao();

movimentacao1.AdicionarConta(conta1);

movimentacao1.AdicionarTransacao("123", transacao1);

Console.WriteLine($"R${movimentacao1.RetornarSaldo("123", new DateOnly(2022, 03, 08)):N2}");