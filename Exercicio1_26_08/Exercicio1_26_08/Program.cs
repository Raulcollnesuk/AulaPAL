int cont = 1, num;
Console.WriteLine("Digite o numero final da repetição: ");
num = int.Parse(Console.ReadLine());

while(cont <= num)
{
    Console.WriteLine(cont);
    cont++;
}