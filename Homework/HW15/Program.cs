// Напишите программу, которая принимает на ввод цифру, обозначающую день недели, и проверяет, является ли этот день недели выходным

Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void ChoiceDay (int dayNumber)
{
   if (dayNumber == 6 || dayNumber == 7)
   {
    Console.WriteLine("выходной");
   } 
  else if (dayNumber < 1 || dayNumber > 7)
  {
    Console.WriteLine("нет такого дня");
  }
  else
  Console.WriteLine("не выходной");
}
ChoiceDay(dayNumber);