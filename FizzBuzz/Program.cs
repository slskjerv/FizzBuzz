using FizzBuzz;

Console.WriteLine("Hei, velkommen til FizzBuzz!");
Console.WriteLine("Er du klar for å spele (1) eller spele av (2)? (Tast 1 eller 2)");

if (Console.ReadLine() is "2")
{
    Console.WriteLine("Greit, la meg printe ut FizzBuzz for deg. " +
        "Vil du ha det forlengs (1) eller baklengs (2)?");

    FizzBuzzService.PrintFizzBuzz(Console.ReadLine()!);

    CloseConsole();
}
else
{
    Console.WriteLine("Vil du spele med standardreglar? Ja/Nei");

    if (Console.ReadLine() is "Ja")
    {
        Console.WriteLine("Me startar på 1 og går til 100:");

        FizzBuzzService.PlayFizzBuzz();
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

        FizzBuzzService.SetRules(number);

        FizzBuzzService.PlayFizzBuzz();
    }

    CloseConsole();
}

static void CloseConsole()
{
    Console.WriteLine("Trykk enter for å lukke applikasjonen");
    Console.ReadLine();
}