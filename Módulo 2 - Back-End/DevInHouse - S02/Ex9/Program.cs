int selecao = 0;
int TotalFatias = 0;

do {
    Console.WriteLine("“Você deseja uma pizza? Envie “1” para calabresa, “2” para mussarela, “3” para portuguesa ou “0” caso esteja satisfeito”");
    
    selecao = Convert.ToInt16(Console.ReadLine());

    if(selecao == 1 || selecao == 2 || selecao ==3){
        TotalFatias++;
    }



} while (selecao != 0);

Console.WriteLine($"Você consumiu {TotalFatias} fatias");