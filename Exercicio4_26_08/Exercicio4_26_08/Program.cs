int cont = 1, ana, anon, idade;



while (cont <= 5)
{
    Console.WriteLine("Digite o seu ano de nascimento: ");
    anon = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o ano atual: ");
    ana = int.Parse(Console.ReadLine());

    idade = ana - anon;

   Console.WriteLine("Você tem: " + idade);
  
}
