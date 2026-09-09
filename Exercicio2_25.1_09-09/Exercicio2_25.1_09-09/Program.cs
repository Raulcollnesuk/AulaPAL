int n, mult, cont = 1; 

while (cont <= 3)

{

    Console.WriteLine("digite numeros: ");

    n = int.Parse(Console.ReadLine());

    mult = n * 9;

    Console.WriteLine("Este número multiplicado por 9 é " + mult);

    cont++;

}