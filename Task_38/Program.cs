// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] m = new int[10];
FillArray(m);
PrintArray(m);
Console.WriteLine();
int maxValue = MaxNumber(m);
int minValue = MinNumber(m);
int difBetweenMaxAndMin = maxValue - minValue;
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {difBetweenMaxAndMin}");

void FillArray(int[] a)
{
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(1, 50);
    }
}
void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
}

int MaxNumber(int[] a)
{
    int max = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }
    }
    return max;
}

int MinNumber(int[] a)
{
    int min = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < min)
        {
            min = a[i];
        }
    }
    return min;
}