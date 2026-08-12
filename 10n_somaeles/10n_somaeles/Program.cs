double num1, soma;
soma = 0;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Digite um número");
    num1 = Double.Parse(Console.ReadLine());

    soma = num1 + soma;
    Console.WriteLine("A soma é :" + soma);
}