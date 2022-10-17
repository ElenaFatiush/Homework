//Zadacha64();
//Zadacha66();
//Zadacha68();


void Zadacha64()
{
    //Задайте значения N и M. Напишите программу,
    //которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("--------");
    FindNatural(M);

    int FindNatural(int M)
    {
       if (M <= N) 
        {
            if (M % 2 == 1)
            {
                return FindNatural(M + 1);
            }
            if (M % 2 == 0)
            {
                Console.WriteLine(M);
                return FindNatural(M + 2);
            }
        }
        return M;
    }
}

void Zadacha66()
{
    //Задайте значения M и N. Напишите программу, 
    //которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии

    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("--------");
    Console.WriteLine(FindNaturalSum(M, N));

    int FindNaturalSum(int M, int N, int sum = 0)
    {
        if (M > N)
        {
            return sum;
        }
        sum += M;
        M++;
        return FindNaturalSum(M, N, sum);

    }
    Console.WriteLine();
}



void Zadacha68()
{
    // Задайте значения M и N. 
    //Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-------------");
    Console.WriteLine(NOD(M,N));
    
    int NOD(int M, int N)
    {
        if (M != N)
        {
            if (M > N)
                return NOD(M-N, N);
            else
                return NOD(M, N-M);
        }
    else 
            return M;
}
}

