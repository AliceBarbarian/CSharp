﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

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
    }

}