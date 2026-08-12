string nome;
int idade, sexo;

for (int i = 1; i<= 3; i++)
{
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu sexo: \n1 nasculino \n2 feminino ");
    sexo = int.Parse(Console.ReadLine());

    if ((idade >=21) && (sexo == 1))
    {
        Console.WriteLine(nome + " de idade" + idade + ", é do genero masculino.");
    }

}

