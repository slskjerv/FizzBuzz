using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(4, "4")]
        [DataRow(3, StringConstants.Fizz)]
        [DataRow(5, StringConstants.Buzz)]
        [DataRow(15, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(30, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(100, StringConstants.Buzz)]
        [DataRow(0, StringConstants.WrongInput)]
        [DataRow(-5, StringConstants.WrongInput)]
        public void FizzBuzzMethod_WhenGivenInputWithStandardRules_ReturnExpected(int input, string expected)
        {
            var result = FizzBuzzService.FizzBuzzMethod(input, false, false);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, StringConstants.Fizz)]
        [DataRow(4, StringConstants.Fuzz)]
        [DataRow(5, StringConstants.Buzz)]
        [DataRow(12, StringConstants.Fizz + StringConstants.Fuzz)]
        [DataRow(15, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(24, StringConstants.Fizz + StringConstants.Fuzz)]
        [DataRow(60, StringConstants.Fizz + StringConstants.Buzz + StringConstants.Fuzz)]
        public void FizzBuzzMethod_WhenGivenInputWithFuzzRule_ReturnExpected(int input, string expected)
        {
            var result = FizzBuzzService.FizzBuzzMethod(input, true, false);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(4, "4")]
        [DataRow(9, StringConstants.Fizz + StringConstants.Jazz)]
        [DataRow(3, StringConstants.Fizz)]
        [DataRow(5, StringConstants.Buzz)]
        [DataRow(15, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(30, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(90, StringConstants.Fizz + StringConstants.Buzz + StringConstants.Jazz)]
        public void FizzBuzzMethod_WhenGivenInputWithJazzRule_ReturnExpected(int input, string expected)
        {
            var result = FizzBuzzService.FizzBuzzMethod(input, false, true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, StringConstants.Fizz)]
        [DataRow(5, StringConstants.Buzz)]
        [DataRow(9, StringConstants.Fizz + StringConstants.Jazz)]
        [DataRow(15, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(30, StringConstants.Fizz + StringConstants.Buzz)]
        [DataRow(60, StringConstants.Fizz + StringConstants.Buzz + StringConstants.Fuzz)]
        [DataRow(90, StringConstants.Fizz + StringConstants.Buzz + StringConstants.Jazz)]
        public void FizzBuzzMethod_WhenGivenInputWithFuzzAndJazzRule_ReturnExpected(int input, string expected)
        {
            var result = FizzBuzzService.FizzBuzzMethod(input, true, true);

            Assert.AreEqual(expected, result);
        }
    }
}