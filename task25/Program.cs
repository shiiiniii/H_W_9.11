﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int PowerArray(int a, int b)
{
    int result = 1; 
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
int powerArray = PowerArray(a , b);
Console.WriteLine($"Чило {a} в степени {b} равно " + powerArray);

