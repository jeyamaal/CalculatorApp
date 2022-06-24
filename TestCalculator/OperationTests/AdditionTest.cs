using CalculatorApp.Operations;
using Xunit;

namespace TestCalculator.OperationTests
{
    public class AdditionTest
    {
        [Fact]
        public void Add_Operation_Success()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 18;

            var actual = new OperationHandler(new Addition()).Execute(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
