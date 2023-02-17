/* Задача 8
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */







Console.WriteLine("Введите положительное число от 2 и более : ");
int number = int.Parse(Console.ReadLine()!);
if (number < 0){
    Console.WriteLine("Ошибка! Введите положительное число.");
}
else {
    for (int i = 2; i <=number; i +=2){
        Console.Write(i + " ");
    }
};

