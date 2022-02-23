
decimal maiorNota = -1;
decimal menorNota = 11;
decimal[] notasTurma = new decimal[3];
decimal media = 0;

for (int i = 0 ; i < 3; i++){

Console.WriteLine("Digite uma nota:");
notasTurma[i] = Convert.ToDecimal(Console.ReadLine()); 

if (notasTurma[i] > maiorNota){

    maiorNota = notasTurma[i];

}  

if(notasTurma[i] < menorNota) {

    menorNota = notasTurma[i];

}

media = media + notasTurma[i];

}

Console.WriteLine($"A maior nota é {maiorNota}");
Console.WriteLine($"A menor nota é {menorNota}");
Console.WriteLine($"A média é {media / 3}");