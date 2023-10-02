// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Dialog(string text)
{
  Console.Write(text);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int SummaElementov(int n, int m)
{
  if (n == m) return n;
  else return SummaElementov(n + 1, m) + n;
}

int n = Dialog("введите N: ");
int m = Dialog("введите M: ");

Console.WriteLine(SummaElementov(n, m));