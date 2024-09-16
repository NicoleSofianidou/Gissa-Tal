

Random random= new Random();
int randomNumber = random.Next(0,101);
int antalgissningar= 0;
Console.WriteLine("Gissa vilket tal jag tänker på");
int svar1= int.Parse(Console.ReadLine());

while (svar1 != randomNumber)
{
    antalgissningar++;
    if (svar1>randomNumber)
    {
        Console.WriteLine("Din gissning är för hög, gissa igen");
    }
    else if (svar1<randomNumber)
    {
        Console.WriteLine("Din gissning är för låg, gissa igen");

    }
    svar1 = int.Parse(Console.ReadLine());
   
}
antalgissningar++;
Console.WriteLine("Grattis du har gissat rätt!");
Console.WriteLine($" Du gissade {antalgissningar} gånger");

