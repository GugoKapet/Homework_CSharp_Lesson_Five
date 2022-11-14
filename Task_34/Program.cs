// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] massive = new int[20];
FillArray(massive);
PrintArray(massive);
Console.WriteLine();
int evenNumbers = CountEvenNumbers(massive);
Console.WriteLine($"Количество четных чисел массива: {evenNumbers}");

void FillArray(int[] m)
{
    Random random = new Random();
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(massive[i]);
    }
}

int CountEvenNumbers(int[] b)
{
    int count = 0;
    for (int i = 0; i < b.Length; i++)
    {
        if (b[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}