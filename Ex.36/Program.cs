// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSum (int[] array)
{
    int sum = 0;
    for (i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] GenerateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(min, max);
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество элементов массива: ");
int min = GetInput("Введите минимальное число диапазона: ");
int max = GetInput("Введите максимальное число диапазона: ");
int[] array = GenerateRandomArray(size, min, max);
Console.WriteLine($"[{String.Join(",", array)}] -> {GetSum(array)}");
