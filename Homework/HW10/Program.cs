﻿// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if ((a >= 1000) || (a <= 99))
{
    Console.WriteLine("Вижу ошибку, не обманывай, вводи новое число");
}
else
    Console.WriteLine($"Второй цифрой числа {a} является {a / 10 % 10}");
