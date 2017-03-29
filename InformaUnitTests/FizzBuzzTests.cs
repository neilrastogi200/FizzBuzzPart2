using InformaFizzBuzz;
using NUnit.Framework;

namespace InformaUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private ICalculation _calculation;

        [SetUp]
        public void SetUp()
        {
            _calculation = new Calculation();
        }


        [Test]
        [TestCase(1, Result = "1")]
        [TestCase(8, Result = "8")]
        [TestCase(2,Result = "2")]
        [TestCase(7,Result = "7")]
        public string DisplayNumber_NotDivisableBy3_5_Or_15(int args)
        {
            //Act
          return  _calculation.DisplayNumber(args);
        }


        [Test]
        [TestCase(3, Result = "lucky")]
        [TestCase(13, Result = "lucky")]
        public string DisplayNumber_Can_Contain_3_Being_Part_Of_The_Number_Returns_Lucky(int args)
        { 
            //Act
           return  _calculation.DisplayNumber(args);
        }

        [Test]
        [TestCase(9,Result = "fizz")]
        [TestCase(6, Result = "fizz")]
        [TestCase(12,Result = "fizz")]
        public string DisplayNumber_CanBeDivisableBy3_Returns_Fizz(int args)
        {
            //Act
            return _calculation.DisplayNumber(args);
        }


        [Test]
        public void DisplayNumber_CanBeDivisableBy5_Returns_Buzz()
        {
            //Arrange
            var input = 5;

            //Act
            var actualResult = _calculation.DisplayNumber(input);

            //Assert
            Assert.AreEqual("buzz",actualResult);

        }

        [Test]
        [TestCase(10, Result = "buzz")]
        [TestCase(20, Result = "buzz")]
        public string DisplayNumber_CanBeDivisableBy5_Returns_Fizz(int args)
        {
            //Act
            return _calculation.DisplayNumber(args);
        }


        [Test]
        public void DisplayNumber_CanBeDivisableBy15_Returns_Buzz()
        {
            //Arrange
            var input = 15;

            //Act
            var actualResult = _calculation.DisplayNumber(input);

            //Assert
            Assert.AreEqual("fizzbuzz", actualResult);

        }
    }
}
