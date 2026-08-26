int num, cont = 1, mult;

while (cont <= 3)
{
    Console.WriteLine("digite um número: ");
    num = int.Parse(Console.ReadLine());

    mult = num * 7;
    Console.WriteLine("os valores são: " + mult);

    cont++;
}