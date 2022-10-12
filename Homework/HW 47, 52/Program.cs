//Zadacha47();
//Zadacha50();
//Zadacha52();

void Zadacha47()
{
    // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    Console.Write("\nСоздание нового массива");
    Console.Write("\n\n Введите количество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] numbers = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.NextDouble() * 200 - 100;
            numbers[i, j] = Math.Round(numbers[i, j], 1);
        }
    }
    PrintDoubleArray(numbers);
}
void PrintDoubleArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha50()
{
    //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.

    Random random = new Random();
    Console.Write("\nСоздание нового массива");
    Console.Write("\n\n Введите количество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("------------");

    Console.WriteLine("Введите индекс строки:");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца:");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i < rows && j < columns)
    {

        Console.WriteLine("------------");
        Console.WriteLine(numbers[i, j]);
    }
    else Console.WriteLine("Введи другие значения");
}




void Zadacha52()
{
    //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Console.WriteLine("Введите количество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, col];
    double[] columns = new double[col];

    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine("Среднее арифметическое столбцов");
    for (int i = 0, k = 0; i < numbers.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            sum += numbers[j, i];
        }
        columns[k] = sum / numbers.GetLength(0);
        Console.WriteLine($"{Math.Round(columns[k]),1} ");
        k++;
    }
}



