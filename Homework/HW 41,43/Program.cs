//Zadacha41();

//Zadacha43();

void Zadacha41()
{
    // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше нуля ввел пользователь.

    Console.WriteLine("Сколько чисел вы хотите ввести?");
    int M = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count += 1;
    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше нуля");
}



void Zadacha43()
{
    // Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнением y=k1*x+b1,
    // y=k2*x+b2. Значения к и б задаются пользователем

    Console.WriteLine("Введите значение k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double b2 = Convert.ToDouble(Console.ReadLine());

    double x = 0;
    double y = 0;

    if (k1 == k2) Console.WriteLine("Точек пересечения нет, линии параллельны");


    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения двух прямых: {x}; {y}");
    }
}


