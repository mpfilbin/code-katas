using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalc
{
    [TestFixture]
    public class Tests
    {
        private StringCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new StringCalculator();
        }

        [Test]
        public void Add_SendInEmptyString_ResultShouldBeZero()
        {
            var input = "";
            var result = _calculator.Add(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_SendInOneValue_ResultShouldBeThatValue()
        {
            var input = "1";
            var result = _calculator.Add(input);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Add_SendInTwoValues_ResultShouldAddValues()
        {
            var input = "2,3";
            var result = _calculator.Add(input);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_SendInThreeValues_ResultShouldAddValues()
        {
            var input = "1,2,3";
            var result = _calculator.Add(input);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_SendInNewLineInBetweenValues_ShouldIgnoreNewLineAndSumValues()
        {
            var input = "1\n2,3";
            var result = _calculator.Add(input);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_SendInCustomDelimiter_ShouldUseDelimiterAndSumValues()
        {
            var input = "//;\n1;2;3";
            var result = _calculator.Add(input);
            Assert.AreEqual(6, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Input cannot contain negative numbers: -100")]
        public void Add_SendInNegativeNumber_ShouldThrowException()
        {
            var input = "-100,10";
            var result = _calculator.Add(input);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Input cannot contain negative numbers: -100,-1")]
        public void Add_SendInNegativeNumbers_ShouldHaveExceptionWithAllNegativeNumbersInMessage()
        {
            var input = "-100,10,-1";
            var result = _calculator.Add(input);
        }

        [Test]
        public void Add_SendInvalidInput_ResultShouldBeZero()
        {
            var input = "a,b,c";
            var result = _calculator.Add(input);
            Assert.AreEqual(0, result);
        }

    }
}
