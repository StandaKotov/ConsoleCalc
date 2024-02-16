using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class Calculator1
    {
        // Метод для сложения двух чисел
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Метод для вычитания двух чисел
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Метод для умножения двух чисел
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Метод для деления двух чисел
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return (double)a / b;
        }
    }
}
