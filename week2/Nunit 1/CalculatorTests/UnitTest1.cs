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
        [TestCase(5, 3, 8)]
        [TestCase(-2, 2, 0)]
        [TestCase(0, 0, 0)]
        public void Addition_ShouldReturnCorrectSum(double a, double b, double expected)
        {
            var result = calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2, 5)]
        public void Division_ShouldReturnCorrectQuotient(double a, double b, double expected)
        {
            var result = calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Division(5, 0));
        }
    }
}
