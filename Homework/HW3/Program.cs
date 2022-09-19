// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

Console.WriteLine("Введите число: ");
int Num = int.Parse(Console.ReadLine());
if(Num%2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}