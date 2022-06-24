using CalculatorApp.Operations;

namespace CalculatorApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double SimpleCalc(double input_1, double input_2, string operand)
        {
            double answer;

            switch (operand)
            {
                case "-":
                    answer = new OperationHandler(new Substraction()).Execute(input_1, input_2);
                    break;
                case "+":
                    answer = new OperationHandler(new Addition()).Execute(input_1, input_2);
                    break;
                case "/":
                    answer = new OperationHandler(new Division()).Execute(input_1, input_2);
                    break;
                case "*":
                    answer = new OperationHandler(new Multiplication()).Execute(input_1, input_2);
                    break;
                default:
                    answer = 0;
                    break;
            }
            return answer;
        }
    }
}
