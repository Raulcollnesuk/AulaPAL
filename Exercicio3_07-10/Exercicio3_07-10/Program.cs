string[] nome = new string[4];
string[] sexo = new string[4];
int[] idade = new int[4];

for (int i = 0; i < 4; i++)
{
Console.WriteLine("Digite seu nome: ");
nome[i] = (Console.ReadLine());
Console.WriteLine("Digite seu sexo: ");
sexo[i] = (Console.ReadLine());
Console.WriteLine("Digite sua idade: ");
idade[i] = int.Parse(Console.ReadLine());
}
 for (int i = 0;i < 4;i++)
{
    Console.WriteLine("O nome armazenado é " + nome[i] + "° no vetor");
    Console.WriteLine("O sexo armazenado é " + sexo[i] + "° no vetor");
    Console.WriteLine("O idade armazenado é " + idade[i] + "° no vetor");
}
