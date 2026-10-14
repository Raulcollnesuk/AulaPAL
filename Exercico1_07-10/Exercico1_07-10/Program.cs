string[] jog =  new string[11];
int p;

for (int i = 0; i < 11; i++)
{
    p = i + 1;
    Console.WriteLine("Digite o nome do jogador: ");
    jog[i] = (Console.ReadLine());
    Console.WriteLine("O jogador armazenado na posição " + p + "° do vetor é o: " + jog[i]);

}