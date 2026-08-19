
double soma = 0, re, mult = 0;
for (int i = 1; i <= 50; i++) 
{ 
    Console.WriteLine(i);
    re = i % 3; if (re == 0)
    
    { mult++; soma = soma + i; } }
Console.WriteLine("A soma dos multiplos é: " + soma);