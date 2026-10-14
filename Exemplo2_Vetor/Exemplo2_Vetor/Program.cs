//para criar um vetor de string
string[] nome = new string[4];

//armazenar dados no vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o nome da posição" + i + "° do vetor");
    nome[i] = Console.ReadLine();

}

//para mostrar valores vetor
for (int i = 0; i < 4;i++)
{
    Console.WriteLine("O nome armazenamento na posição" + i + " ° do vetor =" + nome[i]);
}