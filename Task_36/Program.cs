// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] m = new int[10];
FillArray(m);
PrintArray(m);
int oddNumbersSum = OddNumbersSum(m);
Console.WriteLine($"Сумма нечётных элементов массива: {oddNumbersSum}");
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

int OddNumbersSum(int[] b)
{
    int sum = 0;
    for (int i = 1; i < b.Length;)
    {
        sum += b[i];
        i += 2;
    }
    return sum;
}