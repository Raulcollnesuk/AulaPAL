double resto;
int[] n = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número: ");
    n[i] = int.Parse(Console.ReadLine());
    resto = n[i] % 2;
    if(resto == 0)
    {
        Console.WriteLine("O número " + n[i] + " digitado vetor, é par.");
    }
}