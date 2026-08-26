int cont = 800, resto, somaa = 0;

while (cont > 1)
{
    resto = cont % 2;
    if (resto == 0)
        somaa = somaa + cont;
    else if(resto !=0)
    {
        Console.WriteLine("é impar" + cont);
        
    }
    cont--;
}

Console.WriteLine("O resultado da soma é: " + somaa);
