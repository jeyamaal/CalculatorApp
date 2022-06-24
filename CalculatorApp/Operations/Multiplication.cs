namespace CalculatorApp.Operations
{
    public class Multiplication : IOperationHandler
    {
        public double ExecuteOperation(double x, double y) => x * y;
    }
}
