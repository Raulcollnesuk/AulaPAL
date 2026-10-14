//criar vetor inteiro

int[] vt = new int[7];

 //para armazenar os dados no vetor

  for(int i = 0; i < 7; i++)
{
  Console.WriteLine("Digite o número da posição " + i + " º do vetor: ");
    vt[i] = int.Parse(Console.ReadLine());
}

  //para mostrar os valores do vetor
  for(int i = 0;i < 7; i++)
{
    Console.WriteLine("O valor da posição" + i + "° do vetor é = " + vt[i]);
}