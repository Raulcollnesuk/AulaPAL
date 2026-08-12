int qtd = 0, idade;

for (int i = 1; i<= 5; i ++)
{
    Console.WriteLine("Digite sua idade");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    qtd++;
    Console.WriteLine("o numero de pessoas maiores de 18 são: " + qtd);


}
