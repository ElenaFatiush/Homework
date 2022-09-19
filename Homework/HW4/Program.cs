// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
        if (i % 2 == 0)
            Console.WriteLine(i);
