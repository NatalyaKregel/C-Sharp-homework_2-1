﻿//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
// 456 -> 5, 782 -> 8, 918 -> 1

int SecondNum(int num)
{
    int x = num / 10;
    x = x % 10;
    return x;
}
Console.Write("Введите трехзначное число = ");
int num = Convert.ToInt32(Console.ReadLine());
int x = SecondNum(num);
Console.WriteLine("Вторая цифра нашего числа = " + x);
