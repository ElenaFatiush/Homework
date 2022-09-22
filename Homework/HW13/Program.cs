// Задача 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100)
{
    Console.WriteLine("Число меньше 100");
    Console.WriteLine($"{number} -> третьей цифры нет"); 
}
else
{
    int numscreen = number;
    while(number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"{numscreen} -> {number}");
}
