// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Обозначьте размер массива: ");
string sizeM = Console.ReadLine();
int size = int.Parse(sizeM);
int[] numbers = new int[size];
ArrayFill(numbers);
Console.WriteLine("Наш рандомный массив: ");
ArrayPrint(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего чисел: {numbers.Length}, сумма элементов на нечётных позициях: {sum}");

void ArrayFill(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void ArrayPrint(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}