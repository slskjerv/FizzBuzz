using FizzBuzz;

Console.WriteLine("Hei, la oss spele FizzBuzz!");

var correct = true;
var counter = 1;
Console.WriteLine("Me startar på 1 og går til 100: ");

while (correct)
{
    if (counter is 101)
        break;

    var input = Console.ReadLine();
    var result = FizzBuzzService.FizzBuzzMethod(counter, false, false);
    if (input != result)
    {
        Console.WriteLine($"Feil! Riktig svar er: {result}");
        correct = false;
    }

    counter++;
}

Console.WriteLine("Trykk enter for å lukke applikasjonen");
Console.ReadLine();