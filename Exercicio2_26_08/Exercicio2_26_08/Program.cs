int cont = 1, num;
double quadrado;
Console.WriteLine("Digite o numero final da repetição: ");
num = int.Parse(Console.ReadLine());

//quadrado = Math.Pow(cont, 2);

while(cont <= num)
{
    quadrado = Math.Pow(cont, 2);
    Console.WriteLine(cont + "²" + "=" + quadrado);
    cont++;
}
