// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Enter triple figure: ");
string strNum = Console.ReadLine();
int threeNum = int.Parse(strNum);
strNum = Convert.ToString(threeNum);
Console.WriteLine("second digit of the number: "+strNum[1]);