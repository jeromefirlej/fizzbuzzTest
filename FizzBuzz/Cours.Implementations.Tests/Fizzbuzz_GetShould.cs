using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cours.Implementations.Tests
{
    [TestClass]
    public class Fizzbuzz_GetShould
    {
        private FizzBuzz fizzBuzz;

        [TestInitialize]
        public void BeforeEach()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void ReturnInputToString_WhenInputIsWhatever()
        {
            //Arrange
            var input = 1;

            //Act
            var result = this.fizzBuzz.Get(input);

            //Assert
            Assert.AreEqual(input.ToString(), result);
        }


        [DataTestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(7, "Fizz")]
        public void ReturnFizz_WhenInputIsDivisedPer3(int input, string expected)
        {
            //Act
            var result = this.fizzBuzz.Get(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnBuzz_WhenInputIsDivisedPer5()
        {
            //Arrange
            var input = 5;

            //Act
            var result = this.fizzBuzz.Get(input);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ReturnFizzBuzz_WhenInputIsDivisedPer3And5()
        {
            //Arrange
            var input = 15;

            //Act
            var result = this.fizzBuzz.Get(input);

            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}