using CalculatorApp.Operations;
using Xunit;

namespace TestCalculator.OperationTests
{
    public class DivisionTest
    {

        [Theory(DisplayName = "Division_Operation_Success")]
        [InlineData(40, 8, 5)]
        public void Divide_Operation_Success(double value1, double value2, double expected_ans)
        {
            double x1 = value1;
            double x2 = value2;
            double expected = expected_ans;

            var actual = new OperationHandler(new Division()).Execute(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
