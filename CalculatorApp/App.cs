using CalculatorApp.ServiceRegistry;
using CalculatorApp.Services;
using System;

namespace CalculatorApp
{
    public class App
    {
        public void Run() 
        {
            double input_1;
            double input_2;
            double answer;
            string operand;
            ConsoleKeyInfo status;

            try
            {
                var calcService = ServiceProviders.GetService<ICalculatorService>();

                while (true)
                {
                    Console.Write("Please enter the first number: ");
                    input_1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    input_2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter an operand (+, -, /, *): ");
                    operand = Console.ReadLine();

                    answer = calcService.SimpleCalc(input_1, input_2, operand);

                    Console.WriteLine(input_1.ToString() + " " + operand + " " + input_2.ToString() + " = " + answer.ToString());
                    
                    Console.WriteLine("\n\n ☺ Still need to calculate ? (Y) ☺");
                    
                    status = Console.ReadKey();
                    
                    if (status.Key != ConsoleKey.Y)
                    {
                        break;
                    }
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\n\n Please check the Number Formats");
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("\n\n Not Finite Numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\n {ex.Message}");
            }
        }
    }
}

