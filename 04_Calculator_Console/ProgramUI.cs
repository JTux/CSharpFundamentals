using _04_Calculator_Data;
using System;

namespace _04_Calculator_Console
{
    public class ProgramUI
    {
        private CalculatorRepository _calculator = new CalculatorRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine($"What calculation type would you like to do?\n" +
                    $"1. Addition\n" +
                    $"2. Subtraction\n" +
                    $"3. Multiplication\n" +
                    $"4. Division\n" +
                    $"5. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Subtract();
                        break;
                    case "3":
                        Multiply();
                        break;
                    case "4":
                        Divide();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        continue;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void Add()
        {
            Console.Write("Enter the first number you want to add: ");
            double firstNum = ParseInput();
            Console.Write("Enter the second number you want to add: ");
            double secondNum = ParseInput();

            double sum = _calculator.Add(firstNum, secondNum);
            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }

        private void Subtract()
        {
            Console.Write("Enter the first number: ");
            double firstNum = ParseInput();
            Console.Write("Enter the number you want to subtract from the first: ");
            double secondNum = ParseInput();

            double difference = _calculator.Subtract(firstNum, secondNum);
            Console.WriteLine($"{firstNum} - {secondNum} = {difference}");
        }

        private void Multiply()
        {
            Console.Write("Enter the first number you want to multiply: ");
            double firstNum = ParseInput();
            Console.Write("Enter the second number you want to multiply: ");
            double secondNum = ParseInput();

            double prod = _calculator.Multiply(firstNum, secondNum);
            Console.WriteLine($"{firstNum} * {secondNum} = {prod}");
        }

        private void Divide()
        {
            Console.Write("Enter the first number: ");
            double firstNum = ParseInput();
            Console.Write("Enter the number you would like to divide the first by: ");
            double secondNum = ParseInput();

            double quotient = _calculator.Divide(firstNum, secondNum);
            Console.WriteLine($"{firstNum} / {secondNum} = {quotient}");
        }

        private double ParseInput()
        {
            double output;
            while (!double.TryParse(Console.ReadLine(), out output))
            {
                Console.Write("Enter valid number: ");
            }
            return output;
        }
    }
}