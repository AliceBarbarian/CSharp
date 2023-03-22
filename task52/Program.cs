/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
        int[,] myArray = new int[num1, num2];

        Random random = new Random();

        // Закладываю в массив значения
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[i, j] = random.Next(100);
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

       // Находим среднее арифметическое в каждом столбце
        int numRows = myArray.GetLength(0);
        int numCols = myArray.GetLength(1);
        double[] means = new double[numCols];
        for (int j = 0; j < numCols; j++)
        {
            double sum = 0;
            for (int i = 0; i < numRows; i++)
            {
                sum += myArray[i, j];
            }
            means[j] = sum / numRows;
        }

        // Показываем результат
        Console.WriteLine("Массив:");
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(myArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Значение:");
        for (int j = 0; j < numCols; j++)
        {
           Console.WriteLine($"Столбец {j}: {means[j]}");
        }
    }
}