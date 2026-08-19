int num, resto, mult4 = 0;
for (int i = 0; i <= 10; i++)
{ Console.WriteLine("Digite Numeros: ");
  num = int.Parse(Console.ReadLine());
  resto = num % 4;
 if (resto == 0)
    
    { mult4++; }
}
Console.WriteLine("Os numeros multiplos de 4 são: " + mult4);