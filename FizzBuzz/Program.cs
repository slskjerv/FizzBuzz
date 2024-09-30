﻿using FizzBuzz;

Console.WriteLine("Hei, la oss spele FizzBuzz!");

Console.WriteLine("Vil du spele med standardreglar? Ja/Nei");

var correct = true;
var fuzz = false;
var jazz = false;
var counter = 1;
var endCounter = 101;
var introText = "Me startar på 1 og går til 100: ";

if (Console.ReadLine() is "Ja")
{
    Console.WriteLine(introText);

    PlayFizzBuzz(ref correct, fuzz, jazz, ref counter, endCounter);
}
else
{
    Console.WriteLine("Åhå, du vil gjere det vanskeleg?");
    Console.WriteLine("Skriv 1 om du vil spele med Fuzz-reglar, " +
        "skriv 2 om du vil spele med Jazz-reglar, " +
        "skriv 3 om du vil spele med både Fuzz- og Jazz-reglar, " +
        "skriv 4 om du vil spele FizzBuzz frå 100 og nedover, " +
        "og skriv 5 om du vil spele FizzBuzzFuzzJazz baklengs frå 100");

    var number = Console.ReadLine();

    if (number is "1")
        fuzz = true;
    if (number is "2")
        jazz = true;
    if (number is "3" || number is "5")
    {
        fuzz = true;
        jazz = true;
    }
    if (number is "4" || number is "5")
    {
        counter = 100;
        endCounter = 0;
        introText = "Me startar på 100 og går nedover: ";
    }

    Console.WriteLine(introText);

    PlayFizzBuzz(ref correct, fuzz, jazz, ref counter, endCounter);
}

Console.WriteLine("Trykk enter for å lukke applikasjonen");
Console.ReadLine();

static void PlayFizzBuzz(ref bool correct, bool fuzz, bool jazz, ref int counter, int endCounter)
{
    while (correct)
    {
        if (counter == endCounter)
        {
            Console.WriteLine("Du vant!!");
            break;
        }

        var input = Console.ReadLine();
        var result = FizzBuzzService.FizzBuzzMethod(counter, fuzz, jazz);

        if (input?.ToLowerInvariant() != result.ToLowerInvariant())
        {
            Console.WriteLine($"Feil! Riktig svar er: {result}");
            correct = false;
        }

        counter++;
    }
}