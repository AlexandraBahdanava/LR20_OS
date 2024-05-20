using System;

namespace MaxAndMin
{
    public class Program
    {
        public static double Calculate(double firstNumber, double secondNumber, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Ошибка! Деление на ноль невозможно.");
                        return double.NaN;
                    }
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Ошибка! Некорректная операция.");
                    return double.NaN;
            }

            return result;
        }

        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            char operation;

            Console.WriteLine("Введите первое число:");
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Ошибка! Пожалуйста, введите корректное число:");
            }

            Console.WriteLine("Введите второе число:");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Ошибка! Пожалуйста, введите корректное число:");
            }

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            while (!char.TryParse(Console.ReadLine(), out operation) || (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
            {
                Console.WriteLine("Ошибка! Пожалуйста, выберите одну из доступных операций (+, -, *, /):");
            }
            Console.WriteLine(Calculate(firstNumber, secondNumber, operation));

            Console.ReadKey();
        }

    }
}
