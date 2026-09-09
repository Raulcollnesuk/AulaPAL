int cont = 10, n, div, num;

Console.WriteLine("Digite um número (maior que o 10)");
num = int.Parse(Console.ReadLine());

while(cont <= num)
{
    div = cont / 3;

    Console.WriteLine(cont + "/3");
    Console.WriteLine(div);
    cont++;
}
