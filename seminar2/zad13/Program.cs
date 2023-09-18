// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter triple figure: ");
string anyNum = Console.ReadLine();
string anyNumText = Convert.ToString(anyNum);
if (anyNumText.Length > 2){
  Console.WriteLine("Third number: " + anyNumText[2]);
}
else {
  Console.WriteLine(":Third number is lost");
}