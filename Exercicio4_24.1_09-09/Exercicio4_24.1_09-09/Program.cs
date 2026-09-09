int na, nb, media, cont = 1;
string al;

while (cont <= 5)
{
    Console.WriteLine("Digite seu nome: ");
    al = Console.ReadLine();
    Console.WriteLine("Digite sua primeira nota: ");
    na = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua segunda nota: ");
    nb = int.Parse(Console.ReadLine());

    media = (na + nb) / 2;
    Console.WriteLine(media);
    cont++;
}
