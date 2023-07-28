// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetMinNum (double[] array)
{
    double minNum = array[0];
    int i = 1;
    while (i < array.Length)
    {
       
       if (array[i] < minNum)
       {
        minNum = array[i];
       }
       i++;
    }
    return minNum;
}

double GetMaxNum (double[] array)
{
    double maxNum = array[0];
    int i = 1;
    while (i < array.Length)
    {
       
       if (array[i] > maxNum)
       {
        maxNum = array[i];
       }
       i++;
    }
    return maxNum;
}

double[] GenerateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
         array[i] = rand.Next(min, max + 1) + rand.NextDouble();
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
double[] array = GenerateRandomArray(size, min, max);
Console.WriteLine($"[{String.Join(",", array)}] -> {GetMaxNum(array)} - {GetMinNum(array)} = {(GetMaxNum(array) - GetMinNum(array))}");
