namespace FizzBuzz
{
    public class FizzBuzzService
    {
        private static bool _correct = true;
        private static bool _fuzz = false;
        private static bool _jazz = false;
        private static int _counter = 1;
        private static int _endCounter = 101;

        public static string FizzBuzzMethod(int input, bool fuzzRule, bool jazzRule)
        {
            if (input < 1 || input > 100)
                return StringConstants.WrongInput;

            var output = "";

            if (input % 3 == 0)
                output += StringConstants.Fizz;
            if (input % 5 == 0)
                output += StringConstants.Buzz;
            if (fuzzRule && input % 4 == 0)
                output += StringConstants.Fuzz;
            if (jazzRule && input % 9 == 0)
                output += StringConstants.Jazz;

            if (string.IsNullOrEmpty(output))
                return input.ToString();

            return output;
        }

        public static void PrintFizzBuzz(string input)
        {
            if (input is "1")
            {
                for (int i = 1; i < 101; i++)
                    WriteFizzBuzzToConsole(i);
            }
            else if (input is "2")
            {
                for (int i = 100; i > 0; i--)
                    WriteFizzBuzzToConsole(i);
            }
            else
            {
                Console.WriteLine($"{input} er ikkje eit gyldig val ಠ_ಠ");
                PrintFizzBuzz(Console.ReadLine()!);
            }

            static void WriteFizzBuzzToConsole(int i)
            {
                var result = FizzBuzzMethod(i, false, false);
                Console.WriteLine(result);
            }
        }

        public static void PlayFizzBuzz()
        {
            while (_correct)
            {
                if (_counter == _endCounter)
                {
                    Console.WriteLine("Du vant!!");
                    break;
                }

                var input = Console.ReadLine();
                var result = FizzBuzzMethod(_counter, _fuzz, _jazz);

                if (input?.ToLowerInvariant() != result.ToLowerInvariant())
                {
                    Console.WriteLine($"Feil! Riktig svar er: {result}");
                    _correct = false;
                }

                if (_counter < _endCounter)
                    _counter++;
                else
                    _counter--;
            }
        }

        public static void SetRules(string? number)
        {
            switch (number)
            {
                case "1":
                    _fuzz = true;
                    break;
                case "2": 
                    _jazz = true;
                    break;
                case "3":
                    _fuzz = true;
                    _jazz = true;
                    break;
                case "4":
                    _counter = 100;
                    _endCounter = 0;
                    Console.WriteLine("Me startar på 100 og går til 1: ");
                    break;
                case "5":
                    _fuzz = true;
                    _jazz = true;
                    _counter = 100;
                    _endCounter = 0;
                    Console.WriteLine("Me startar på 100 og går til 1: ");
                    break;
                default:
                    Console.WriteLine("Tal ikkje gyldig ಠ_ಠ");
                    SetRules(Console.ReadLine());
                    break;
            }
        }
    }
}

