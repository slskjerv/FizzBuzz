namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public static string FizzBuzzMethod(int input)
        {
            if (input < 1 || input > 100)
                return StringConstants.WrongInput;

            if (input % 3 == 0 && input % 5 == 0)
                return StringConstants.Fizz + StringConstants.Buzz;

            if (input % 3 == 0)
                return StringConstants.Fizz;

            if (input % 5 == 0)
                return StringConstants.Buzz;

            return input.ToString();
        }
    }
}

