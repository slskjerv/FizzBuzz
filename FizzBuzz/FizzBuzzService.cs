namespace FizzBuzz
{
    public class FizzBuzzService
    {
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
    }
}

