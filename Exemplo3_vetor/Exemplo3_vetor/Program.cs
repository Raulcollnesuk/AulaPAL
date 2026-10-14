//para criar um vetor de string
string[] nome = new string[4];
//para criar um vetor de int
int[] idade = new int[4];

//armazenar dados no vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o nome da posição" + i + "° do vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição" + i + "° do vetor");
    idade[i] = int.Parse(Console.ReadLine());

}

//para mostrar valores vetor
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome armazenamento na posição" + i + " ° do vetor =" + nome[i]);
    Console.WriteLine("A idade armazenda na posição" + i + "° do vetor =" + idade[i]);
}