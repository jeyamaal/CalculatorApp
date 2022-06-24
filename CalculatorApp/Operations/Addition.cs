namespace CalculatorApp.Operations
{
    public class Addition : IOperationHandler
    {
        public double ExecuteOperation(double x, double y) => x + y;
    }
}
