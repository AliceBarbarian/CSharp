/* Задача 0.
Напишите программу, которая на вход принимает число и выдает его квадрат (умножение на само себя)  

Например:
4 -> 16
-3 -> 9
-7 -> 49 

Console.Write("Введите чиcло: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + sqr); */


/* Задача 1.

Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго.

a=25; b=55-> да

a=2, b = 10 нет

a=9, b=-3 -> да

a=-3 b = 9 -> нет 

Console.Write("Введите первое чиcло: ");
int firstnumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе чиcло: ");
int secondnumber = int.Parse(Console.ReadLine()!);
int sqr = secondnumber * secondnumber ;
if
    (sqr == firstnumber)
        Console.WriteLine("Первое число является квадратом второго");
else
    Console.WriteLine("Первое число не является квадратом второго"); */


/* Задача 3
Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда

5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
        int num = int.Parse(Console.ReadLine()!);

        switch (num) {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;

                default:
                Console.WriteLine("Ошибка. Пожалуйста, введите число от 1 до 7.");
                break;
             }; */
