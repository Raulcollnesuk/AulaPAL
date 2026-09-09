int cont = 1, num, soma = 0;
Console.WriteLine("Digite um múmero: ");
num = int.Parse(Console.ReadLine());
while (cont <= num)
{
    soma = soma + num;
    Console.WriteLine(cont);
    cont++;
}
Console.WriteLine("a soma de tds é: " +  soma);