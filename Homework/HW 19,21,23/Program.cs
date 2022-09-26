//Zadacha19();

//Zadacha19var2();

//Zadacha21();

//Zadacha23();


void Zadacha19()
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    //является ли оно палиндромом

    Console.WriteLine("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if ((num > 99999) || (num < 10000))
    {
        Console.WriteLine("Это не пятизначное число! Введите новое");
    }
    else if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else 
        Console.WriteLine($"Число {num} не является палиндромом");

}

void Zadacha19var2()
{
  Console.WriteLine("Введите пятизначное число: ");
  int num = Convert.ToInt32(Console.ReadLine()); 
  string numstr = Convert.ToString(num);
  if (num > 99999 | num < 10000)
  {
    Console.WriteLine("Это не пятизначное число! Введите новое");
  }
  else
  {
    if (numstr [4] == numstr[0] & numstr[3] == numstr[1])
    {
       Console.WriteLine($"Число {num} является палиндромом"); 
    }
    else
     Console.WriteLine($"Число {num} не является палиндромом"); 
  }
}


void Zadacha21()
{
    // Напишите программу, которая принимает на вход координаты двух точек
    //и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите первое значение первой координаты");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение первой координаты");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье значение первой координаты");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое значение второй координаты");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение второй координаты");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третьк значение второй координаты");
int bz = Convert.ToInt32(Console.ReadLine());

int k = bx - ax;
int m = by - ay;
int n = bz - az;

double lenght = Math.Sqrt(k*k + m*m + n*n);
lenght = Math.Round(lenght,2);
Console.WriteLine($"Длина {lenght}");
}


void Zadacha23()
{
    // Напишите программу, которая принимает на вход число N
    //и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double Cube;
    while (i <= num)
    {
        Cube = Math.Pow(i,3);
         Console.WriteLine($"|{i}|{Cube}|");
        i++;
    }

}


