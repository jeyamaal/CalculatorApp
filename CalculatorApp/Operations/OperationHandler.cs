namespace CalculatorApp.Operations
{
    public class OperationHandler
    {
        IOperationHandler _operation;

        public OperationHandler(IOperationHandler operation)
        {
            _operation = operation;
        }

        public double Execute(double a, double b) => _operation.ExecuteOperation(a, b);
    }
}
