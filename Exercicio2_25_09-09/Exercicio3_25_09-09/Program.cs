double n, calc, cont = 1; while (cont <= 7)
{
    Console.WriteLine("Digite Numero: ");
    n = double.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        calc = Math.Pow(n, 2);
        Console.WriteLine(calc);
    }

    else
    {
        calc = Math.Pow(n, 3);
        Console.WriteLine(calc);
    }
    cont++;
}
