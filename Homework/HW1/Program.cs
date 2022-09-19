Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b) max = a;
if (a > b) min = b;
if (b > a) max = b;
if (b > a) min = a;

Console.Write("Большее число равно = ");
Console.WriteLine(max);
Console.Write("Меньшее число равно = ");
Console.WriteLine(min);
