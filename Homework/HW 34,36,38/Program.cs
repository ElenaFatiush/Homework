Zadacha34();

// Zadacha36();

//Zadacha38();


void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}


void Zadacha34()
{
    // Задайте массив заполненный случайными положительными трехзначными числами. 
    //Напишите программу, которая покажет количество четных чисел в массиве

    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    FindAmountNum(numbers);

}

void FindAmountNum(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве равно {count}");

}




void Zadacha36()
{
    // Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов, стоящих на нечетных позициях.

    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += numbers[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равно {sum}");
}




void Zadacha38()
{
    // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива

    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] numbers = new double[size];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    Raznica(numbers);
    

}

void FillArrayDouble(double[] numbers)
{
Random random = new Random();

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(random.NextDouble() * 20 - 10, 2);
}
}

void PrintArrayDouble(double[] numbers)

{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

void Raznica(double[] numbers)
{
    double Max = numbers[0];
    double Min = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > Max)
    {
        Max = numbers[i];
    }
    else if (numbers[i] < Min)
    {
        Min = numbers[i];
    }
}
Console.WriteLine(Max);
Console.WriteLine(Min);
Console.WriteLine("Разница между максимальным и минимальным элементами равна "+ Math.Round((Max-Min),2));

}

