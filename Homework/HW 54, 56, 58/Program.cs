//Zadacha54();
//Zadacha56();
//Zadacha58();

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

void Zadacha54()
{
    //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("------------");
    SortArray(numbers);

    void SortArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = j + 1; k < columns; k++)
                {
                    if (numbers[i, j] < numbers[i, k])
                    {
                        (numbers[i, j], numbers[i, k]) = (numbers[i, k], numbers[i, j]);
                    }
                }
            }
        }
        PrintArray(numbers);
    }
}

void Zadacha56()
{
    //Задайте прямоугольный двумерный массив. 
    //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    int[,] numbers = new int[4, 5];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("------------");
    int minSum = SumElements(numbers, 0);
    int IndexMin = 0;

    for (int i = 1; i < numbers.GetLength(0); i++)
    {
        int sum = SumElements(numbers, i);
        if (sum < minSum)
        {
            minSum = sum;
            IndexMin = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов = {minSum}, находится в {IndexMin + 1} строке");

    int SumElements(int[,] numbers, int i)
    {
        int columns = numbers.GetLength(1);
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
        return sum;
    }
}

void Zadacha58()
{
    //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

    Random random = new Random();
    int rowsFirst = random.Next(4, 8);
    int columnsFirst = random.Next(4, 8);
    int rowsSecond = columnsFirst;
    int columnsSecond = random.Next(4, 8);
    int[,] FirstMatrix = new int[rowsFirst, columnsFirst];
    int[,] SecondMatrix = new int[rowsSecond, columnsSecond];
    FillArray(FirstMatrix);
    PrintArray(FirstMatrix);
    Console.WriteLine("------------");
    FillArray(SecondMatrix);
    PrintArray(SecondMatrix);
    Console.WriteLine("------------");

    int[,] result = new int[rowsFirst, columnsSecond];

    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columnsSecond; j++)
        {
            for (int k = 0; k < columnsFirst; k++)
            {
                result[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
            }
        }
    }
    PrintArray(result);

}


