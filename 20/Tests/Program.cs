using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace MaxAndMin.Tests
{
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

