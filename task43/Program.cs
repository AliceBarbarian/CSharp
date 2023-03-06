/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Принимаем от пользователя числа
        Console.Write("Введите первое число: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите четвертое число: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        // Проверяем не парралельны ли прямые, если нет – расчёт
        if (b1 == b2)
        {
            Console.Write("Ошибка! Линии парралельны.");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"Точка пересечения: ({x}, {y}).");
        }
        Console.ReadKey();
    }
};
