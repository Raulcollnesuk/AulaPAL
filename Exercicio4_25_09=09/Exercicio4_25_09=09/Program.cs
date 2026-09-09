int n, tab, cont = 1;
Console.WriteLine("Digite um numero: ");
n = int.Parse(Console.ReadLine());
while (cont <= 30)

{

    tab = n * cont;

    Console.WriteLine(tab);

    cont++;
}