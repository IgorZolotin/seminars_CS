// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number of the day: ");
string dayNum = Console.ReadLine();
int dayNumber = int.Parse(dayNum);

void CheckWeekDay (int dayNum) {
  if (dayNumber == 6 || dayNum == 7) {
  Console.WriteLine("это выходной? - да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("число за границей выбора");
  }
  else Console.WriteLine("это выходной? - нет");
}
CheckWeekDay(dayNumber);