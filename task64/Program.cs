﻿//  Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        NaturalToLow(number, count);
    }

    static void NaturalToLow(int n, int count)
    {
        if (count > n)
        {
            return;
        }
        else
        {
            NaturalToLow(n, count + 1);
            Console.Write(count + " ");
        }
    }
};