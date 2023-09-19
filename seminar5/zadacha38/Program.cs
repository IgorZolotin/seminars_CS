// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Обозначьте размер массива: ");
string sizeM = Console.ReadLine();
int size = int.Parse(sizeM);
double[] numbers = new double[size];
ArrayFill(numbers);
Console.WriteLine("Наш рандомный массив: ");
ArrayPrint(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего чисел: {numbers.Length}. MAX значение = {max}, MIN значение = {min}");
Console.WriteLine($"Разница между max и min значением = {max - min}");

void ArrayFill(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void ArrayPrint(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}