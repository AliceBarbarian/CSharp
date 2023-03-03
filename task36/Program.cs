﻿/*
Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Создаём массив из 10
int[] numbers = new int[10];

// Генерируем случайные числа от 100 до 999 и заполняем массив
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 101);
    }

// Показываем массив
Console.WriteLine("Массив: " + string.Join(", ", numbers));

// Подсчитываем сумму элементов стоящих на нечётных позициях
int sum = 0;
for (int i = 1; i < numbers.Length; i += 2)
    {
    sum += numbers[i];
    }

// Показываем сумму
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях: {sum}");