/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> по данным индексам такого числа в массиве нет */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Узнаю длину и ширину
        Console.WriteLine("Введиите значения длины и ширины массива:");
        int num1 = int.Parse(Console.ReadLine()!);
        int num2 = int.Parse(Console.ReadLine()!);

        // Создаю массив
        double[,] myArray = new double[num1, num2];

        Random random = new Random();

        // Закладываю в массив значения
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[i, j] = Math.Round(random.Next(-100,100) * 0.1, 1);
            }
        }

        // Вывожу массив
        for (int x = 0; x < myArray.GetLength(0); x++)
        {
            for (int y = 0; y < myArray.GetLength(1); y++)
            {
              Console.Write(myArray[x, y] + "\t");
            }
        Console.WriteLine();
        }

        // Узнаю возвращаемый элемент
        Console.WriteLine("Введите индекс строки и столбца: ");
        int iA = int.Parse(Console.ReadLine()!);
        int iB = int.Parse(Console.ReadLine()!);

        // Цикл
        if (iA >= 0 && iA< num1 && iB >= 0 && iB < num2) 
        {
            Console.WriteLine($"Значение элемента [{iA},{iB}] это {myArray[iA, iB]}");
        } else 
        {
            Console.WriteLine("По данным индексам такого числа в массиве нет");
        }
        Console.ReadKey(); 
    }
}