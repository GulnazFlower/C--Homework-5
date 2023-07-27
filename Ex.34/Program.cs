// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetEvenNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] GenerateRandomArray(int size, int start, int finish)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество элементов массива: ");
int[] array = GenerateRandomArray(size, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}] -> {GetEvenNum(array)}");
