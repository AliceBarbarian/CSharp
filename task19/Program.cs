/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */




using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int num = int.Parse(Console.ReadLine());

        // check if the number is a five-digit number
        if (num < 10000 || num > 99999)
        {
            Console.WriteLine("Ошибка! Введите пятизначное число.");
        }
        else
        {
            // extract digits from the number
            int digit1 = num / 10000;
            int digit2 = (num / 1000) % 10;
            int digit4 = (num / 10) % 10;
            int digit5 = num % 10;

            // check if the number is a palindrome
            if (digit1 == digit5 && digit2 == digit4)
            {
                Console.WriteLine(num + " да ");
            }
            else
            {
                Console.WriteLine(num + " нет ");
            }
        }
    }
}