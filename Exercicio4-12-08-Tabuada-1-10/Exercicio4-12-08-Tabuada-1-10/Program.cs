int num, tabuada;
Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("Tabuada de " + num );
for (int i = 0; i <= 10; i++)
{
    tabuada = num * i;
    Console.WriteLine(tabuada);
}
