double quadrado, numero;

for (int i= 1; i<= 5; i++)
{
    Console.WriteLine("Digite um numero");
    numero = double.Parse(Console.ReadLine());

    quadrado = Math.Pow(numero, 2);
    Console.WriteLine("Esse número ao quadrado é igual a: " + quadrado);


}