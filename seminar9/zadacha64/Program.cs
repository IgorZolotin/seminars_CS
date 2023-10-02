// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Dialog(string text)
{
  Console.Write(text);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int PositiveInteger(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{PositiveInteger(n, m + 1)}, ");
  return m;
}

int n = Dialog("введите N: ");
if (n < 1)
{
  Console.WriteLine("введите положительное число");
  return;
}
Console.WriteLine(PositiveInteger(n, 1));