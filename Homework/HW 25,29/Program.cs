//Zadacha();

//Zadacha25();  

//Zadacha27();

Zadacha29();


void Zadacha25()
{
    // Используя определение степени числа, напишите цикл, 
    //который принимает на вход два натуральных числа и возводит первое число в степень второго

    
    int Pow(int arg1, int arg2)
    {
    int result = 1;
        for(int i = 1; i <= arg2; i++)
        {
            result = result * arg1;
        }
        return result;
    }

    Console.WriteLine("Введите первое число");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int B = Convert.ToInt32(Console.ReadLine());

    int sum = Pow(A,B);
    Console.WriteLine($"Результат равен {sum}");
}

  


void Zadacha27()
{
    // Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------"); 
int a = num;
int result = 0;
while(a > 0)
{
    result = result + a % 10;
    a = a / 10;
}

Console.WriteLine($"Сумма цифр в числе {num} равна {result}");
}




void Zadacha29()
{
    // Напишите программу, которая задает массив из N элементов и выводит их на экран

    //Решение для рандомного ввода программой. Можно сделать ручной ввод
    // каждого значения со считыванием, затем преобразовать в массив и с циклом вывести


Random random = new Random();
int size = random.Next(4,10);
int [] array = new int[size];

for(int i = 0; i < size; i++)
{
  array[i] = random.Next(0,99);
  Console.Write(array[i] + "  ");
} 

}



void Zadacha()
{
    // Задать массив из 10 чисел и найти max

Random random = new Random();
int size = 9;
int [] array = new int[size];

for(int i = 0; i < size; i++)
{
  array[i] = random.Next(-10,10);
  Console.Write(array[i] + "  ");
} 
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    { 
        max = array[i];
        Console.WriteLine(max);
    }
}

}


