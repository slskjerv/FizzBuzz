using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, StringConstants.Fizz)]
        [DataRow(5, StringConstants.Buzz)]
        [DataRow(15, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(30, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(100, StringConstants.Buzz)]
        [DataRow(0, StringConstants.WrongInput)]
        [DataRow(-5, StringConstants.WrongInput)]
        public void FizzBuzzMethod_WhenGivenInput_ReturnExpected(int input, string expected)
        {
            var result = FizzBuzzService.FizzBuzzMethod(input);

            Assert.AreEqual(expected, result);
        }
    }
}