using FizzBuzz;

Console.WriteLine("Hei, la oss spele FizzBuzz!");

var correct = true;
var counter = 1;
Console.WriteLine("Me startar på 1 og går til 100: ");

while (correct)
{
    var input = Console.ReadLine();

    var result = FizzBuzzService.FizzBuzzMethod(counter);
    if (input != result)
    {
        Console.WriteLine($"Feil! Riktig svar er: {result}");
        correct = false;
    }

    counter++;
}

Console.WriteLine("Trykk enter for å lukke applikasjonen");
Console.ReadLine();