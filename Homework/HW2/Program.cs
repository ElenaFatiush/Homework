Console.WriteLine("Введите три числа через пробел: ");

string [] arr = Console.ReadLine().Split();

int num0 = int.Parse(arr[0]);
int num1 = int.Parse(arr[1]);
int num2 = int.Parse(arr[2]);

if(num0 > num1 & num0 > num2)
{
    Console.WriteLine(num0);
}

if(num1 > num2 & num1 > num0)
{
     Console.WriteLine(num1);
}

if(num2 > num0 & num2 > num1)
{
     Console.WriteLine(num2);
}

