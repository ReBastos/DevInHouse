Console.WriteLine("Digite um número:");

int number = 0;
int total = 0;

do{
number = Convert.ToInt16(Console.ReadLine());
total = number;

} while (number <= 0 && number > 10);

for (int i = number - 1; i >= 1; i--){

total = total * i;

}

Console.WriteLine(number);

Console.WriteLine($"{number} fatorial é: {total}");