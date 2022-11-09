﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    num = Math.Abs(num);
    int sum = 0;
    int i = 0;
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
        i++;
    }
    return sum;

}
int sumNumbers = SumNumbers(num);
Console.WriteLine($"Сумма цифр в числе {num} равна:" + sumNumbers);