int qtdpos = 0, qtdng = 0, num;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número");
    num = int.Parse(Console.ReadLine());

    if (num > 0) 
    {
        qtdpos++;
    }
    else if (num < 0)
    {
        qtdng++;
    }
}
Console.WriteLine("O seu número positivo é:" + qtdpos);
Console.WriteLine("O seu número negativo é:" + qtdng);