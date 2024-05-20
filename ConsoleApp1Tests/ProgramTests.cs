using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace MaxAndMin.Tests
{
    [TestClass]
    public class ProgramDataDrivenTests
    {
        [DataTestMethod]
        [DataRow(5, 3, '+', 8)]  // Тест для проверки сложения двух чисел
        [DataRow(5.3, 3.1, '+', 8.4)]  // Тест для проверки сложения двух десятичных чисел
        [DataRow(5, 3, '-', 2)]  // Тест для проверки вычитания одного числа из другого
        [DataRow(5.5, 3.1, '-', 2.4)]  // Тест для проверки вычитания десятиных чисел
        [DataRow(5, 3, '*', 15)]  // Тест для проверки умножения двух чисел
        [DataRow(5.1, 3.8, '*', 19.38)]  // Тест для проверки умножения двух десятичных чисел
        [DataRow(10, 5, '/', 2)]  // Тест для проверки деления одного числа на другое
        public void TestDataDriven(double firstNumber, double secondNumber, char operation, double expectedResult)
        {
            double result = Program.Calculate(firstNumber, secondNumber, operation);
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(5, 0, '/')]  // Тест для проверки деления на ноль
        public void TestDivisionByZero(double firstNumber, double secondNumber, char operation)
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                double result = Program.Calculate(firstNumber, secondNumber, operation);
                string expected = "Ошибка! Деление на ноль невозможно.\r\n";
                Assert.AreEqual(double.NaN, result);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [DataTestMethod]
        [DataRow(5, 3, '%')]  // Тест для проверки ввода некорректной операции
        public void TestInvalidOperationInput(double firstNumber, double secondNumber, char operation)
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                double result = Program.Calculate(firstNumber, secondNumber, operation);
                string expected = "Ошибка! Некорректная операция.\r\n";
                Assert.AreEqual(double.NaN, result);
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
    
        [TestClass()]
    public class ProgramTests
    {

        // Тест для проверки сложения двух чисел
        [TestMethod]
        public void TestAddition()
        {
            double result = Program.Calculate(5, 3, '+');
            Assert.AreEqual(8, result);
        }

        // Тест для проверки сложения двух десятичных чисел
        [TestMethod]
        public void TestDoubleAddition()
        {
            double result = Program.Calculate(5.3, 3.1, '+');
            Assert.AreEqual(8.4, result);
        }

        // Тест для проверки вычитания одного числа из другого.
        [TestMethod]
        public void TestSubtraction()
        {
            double result = Program.Calculate(5, 3, '-');
            Assert.AreEqual(2, result);
        }

        // Тест для проверки вычитания десятиных чисел.
        [TestMethod]
        public void TestDoubleSubtraction()
        {
            double result = Program.Calculate(5.5, 3.1, '-');
            Assert.AreEqual(2.4, result);
        }

        // Тест для проверки умножения двух чисел.
        [TestMethod]
        public void TestMultiplication()
        {
            double result = Program.Calculate(5, 3, '*');
            Assert.AreEqual(15, result);
        }

        // Тест для проверки умножения двух десятичных чисел.
        [TestMethod]
        public void TestDoubleMultiplication()
        {
            double result = Program.Calculate(5.1, 3.8, '*');
            Assert.AreEqual(19.38, result);
        }

        // Тест для проверки деления одного числа на другое.
        [TestMethod]
        public void TestDivision()
        {
            double result = Program.Calculate(10, 5, '/');
            Assert.AreEqual(2, result);
        }

        // Тест для проверки деления на ноль.
        [TestMethod]
        public void TestDivisionByZero()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                double result = Program.Calculate(5, 0, '/');
                string expected = "Ошибка! Деление на ноль невозможно.\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // Тест для проверки ввода некорректной операции.
        [TestMethod]
        public void TestInvalidOperationInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                double result = Program.Calculate(5, 3, '%');
                string expected = "Ошибка! Некорректная операция.\r\n";
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        // Тест для проверки ввода некорректной операции, а затем корректного ввода.
        [TestMethod]
        public void TestInvalidOperationThenValidInput()
        {
            double result = Program.Calculate(5, 3, '%');
            Assert.AreEqual(double.NaN, result);

            result = Program.Calculate(5, 3, '+');
            Assert.AreEqual(8, result);

        }
    }
}

