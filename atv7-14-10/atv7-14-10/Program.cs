string[] nome = new string[7];
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Digite o nome do time de futebol: ");
    nome[i] = Console.ReadLine();
}

for (int i = 0;i < 7;i++)
{
    Console.WriteLine("Os jogadores armazendos são: " + nome[i]);
}