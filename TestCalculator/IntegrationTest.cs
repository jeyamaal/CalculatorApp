using CalculatorApp.Services;
using System;
using Xunit;

namespace TestCalculator
{
    public class IntegrationTest
    {
        public ICalculatorService _calculatorService;
        public IntegrationTest() => _calculatorService = new CalculatorService();

        [Theory]
        [InlineData(40, 8, "+", 48)]
        [InlineData(20, 8, "-", 12)]
        [InlineData(40, 8, "/", 5)]
        [InlineData(40, 8, "*", 320)]
        public void OperationService_Success(double value1, double value2, string operand, double expected_ans) 
        {
            var actualAns = _calculatorService.SimpleCalc(value1, value2, operand);

            Assert.Equal(expected_ans, actualAns);
        }

        [Fact]
        public void Throw_DivideByZero_Exception()
        {
            double a = 100;
            double b = 0;
            string operand = "/";

            void act() => _calculatorService.SimpleCalc(a, b, operand);

            Assert.Throws<DivideByZeroException>(act);
        }

        [Fact]
        public void Throw_NumberFormat_Exception()
        {
            string input_1 = "a";

            void act() => Convert.ToDouble(input_1);

            Assert.Throws<FormatException>(act);
        }
    }
}
