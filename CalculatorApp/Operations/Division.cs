using System;

namespace CalculatorApp.Operations
{
    public class Division : IOperationHandler
    {
        public double ExecuteOperation(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("2nd input cannot be zero");
            }
            return x / y;
        }
    }
}
