/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


using System;

class Program
{
    static void Main(string[] args)
    {

         double getDistance (double xCorA, double yCorA, double zCorA, double xCorB, double yCorB, double zCorB) 
        { 
            return Math.Sqrt((xCorB-xCorA)*(xCorB-xCorA)+(yCorB-yCorA)*(yCorB-yCorA)+(zCorB-zCorA)*(zCorB-zCorA)); 
        } 

        Console.WriteLine("Введите координаты точки A: ");
        double xCorA = Convert.ToDouble(Console.ReadLine());
        double yCorA = Convert.ToDouble(Console.ReadLine());
        double zCorA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B: ");
        double xCorB = Convert.ToDouble(Console.ReadLine());
        double yCorB = Convert.ToDouble(Console.ReadLine());
        double zCorB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Дистанция между точками: " + Math.Round(getDistance(xCorA, yCorA, zCorA, xCorB, yCorB, zCorB), 2));
        Console.ReadKey();
    }
}