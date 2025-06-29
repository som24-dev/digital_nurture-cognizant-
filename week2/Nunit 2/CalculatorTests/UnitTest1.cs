using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator.AllClear();
        }

        [Test]
        [TestCase(10, 4, 6)]
        [TestCase(5, 2, 3)]
        [TestCase(0, 0, 0)]
        public void Subtraction_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(0, 5, 0)]
        [TestCase(-2, -4, 8)]
        public void Multiplication_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void Division_ShouldReturnCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowArgumentException()
        {
            try
            {
                calculator.Division(5, 0);
                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
            }
        }

        [Test]
        public void TestAddAndClear()
        {
            double result = calculator.Addition(10, 20);
            Assert.That(result, Is.EqualTo(30));

            calculator.AllClear();
            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }
    }
}
