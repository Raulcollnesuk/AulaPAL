int num, par = 0, res;
for (int i = 1; i <= 15; i++) 
{
    Console.WriteLine("Digite um numero: ");
    num = int.Parse(Console.ReadLine());
    res = num % 2;
    if (res == 0)
    { par++; } }
Console.WriteLine("Os numeros pares são: " + par);