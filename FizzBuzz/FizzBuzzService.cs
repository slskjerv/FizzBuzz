namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public static string FizzBuzzMethod(int input)
        {
            if (input < 1 || input > 100)
                return "Feil input";

            if (input % 3 == 0 && input % 5 == 0)
                return "Fizz Buzz";

            if (input % 3 == 0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
}
