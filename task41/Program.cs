/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

//Console.Write("Сколько чисел вы хотите ввести? ");


//int num = Convert.ToInt32(Console.ReadLine);

using System;

class Program
{
    static void Main(string[] args)
    {
        // Узнаем сколько чисел хочет ввести пользователь
        Console.WriteLine("Сколько чисел вы хотите ввести? ");
        int numCount = Convert.ToInt32(Console.ReadLine());

        // Счётчик положительных чисел
        int numPlusCount = 0;

        // Создаем массив из М чисел, наполняем его и считаем положительные числа
        for (int i = 0; i < numCount; i++)
        {
            Console.WriteLine($"Введите число {i+1}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                numPlusCount++;
            }
        }
        
        // Вывод
        Console.Write($"Вы ввели {numPlusCount} положительных чисел!");
        Console.ReadKey();
    }
};
