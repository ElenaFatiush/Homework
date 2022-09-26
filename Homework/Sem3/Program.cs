// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа.
//Необходимо вывести максимальную цифру в полученном округленном значении площади круга

Console.WriteLine("Введите значение радиуса:");
double r = Convert.ToDouble(Console.ReadLine());
double Sqr = Math.PI * Math.Pow(r,2);
Console.WriteLine($"Площадь круга равна {Sqr}");
double result = Math.Round(Sqr);
Console.WriteLine(result);
int n = (int) result;
int max = 0;
while (n>0)
{
    if (max < n % 10) max = n % 10;
    n /= 10;
}
Console.WriteLine(max);





