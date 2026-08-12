double num, met;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Digite seu número");
    num = double.Parse(Console.ReadLine());
    met = num / 2;
    Console.WriteLine("A matede é: " + met);
}