using System;
using System.Text;
namespace ConsoleCalc;
class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Calculator1 calc = new Calculator1();

        Console.WriteLine("Введите первое число:");
        int num1;
        if (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Ошибка: введите целое число.");
            return;
        }

        Console.WriteLine("Введите второе число:");
        int num2;
        if (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Ошибка: введите целое число.");
            return;
        }

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        int choice = Convert.ToInt32(Console.ReadLine());

        int result = 0;

        switch (choice)
        {
            case 1:
                result = calc.Add(num1, num2);
                break;
            case 2:
                result = calc.Subtract(num1, num2);
                break;
            case 3:
                result = calc.Multiply(num1, num2);
                break;
            case 4:
                double divisionResult = calc.Divide(num1, num2);
                if (divisionResult != 0)
                {
                    Console.WriteLine("Результат деления: " + divisionResult);
                    return;
                }
                else
                {
                    return;
                }
            default:
                Console.WriteLine("Неверный выбор операции!");
                return;
        }

        Console.WriteLine("Результат операции: " + result);


        // Код пишем тут
        // Не забываем про break;
        // Не забываем про деление на ноль
        // Не забываем про некорректный ввод (например, буквы)

        //Console.Write("Введите первое число: ");

        //Console.Write("Введите второе число: ");

    }
}
