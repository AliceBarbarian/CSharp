/* Задача 1.

Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго.

a=25; b=55-> да

a=2, b = 10 нет

a=9, b=-3 -> да

a=-3 b = 9 -> нет */

Console.Write("Введите первое чиcло: ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе чиcло: ");
int secondnumber = int.Parse(Console.ReadLine()!);
int sqr = secondnumber * secondnumber ;
if
    (sqr == firstnumber)
        Console.WriteLine("Первое число является квадратом второго");
else
    Console.WriteLine("Первое число не является квадратом второго"); 

