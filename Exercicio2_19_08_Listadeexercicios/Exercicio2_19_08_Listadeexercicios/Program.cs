double re, mult = 0;

for (int i = 1; i <= 300; i++) 
{
   
    Console.WriteLine(i);


    re = i% 3;

    if (re == 0)
    {
        mult++;
    }

}

Console.WriteLine("os multiplos de 3 são " + mult);