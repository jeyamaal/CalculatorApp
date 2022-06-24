using CalculatorApp.Operations;
using Xunit;

namespace TestCalculator.OperationTests
{
    public class MultiplicationTest
    {
        [Fact]
        public void Multiplication_Operation_Success()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 80;

            var actual = new OperationHandler(new Multiplication()).Execute(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
