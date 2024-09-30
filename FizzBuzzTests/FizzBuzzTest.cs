using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "Fizz Buzz")]
        public void FizzBuzzMethod_WhenGivenInput_ReturnExpected(int input, string expected)
        {
            var result = FizzBuzzService.FizzBuzzMethod(input);

            Assert.AreEqual(expected, result);
        }
    }
}