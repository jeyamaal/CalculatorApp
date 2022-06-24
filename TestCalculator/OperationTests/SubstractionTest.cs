using CalculatorApp.Operations;
using Xunit;

namespace TestCalculator.OperationTests
{
    public class SubstractionTest
    {
        [Fact]
        public void Substract_Operation_Success()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            var actual = new OperationHandler(new Substraction()).Execute(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
