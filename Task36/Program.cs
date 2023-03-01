// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void CreateArray(int[] array)
{
    int arr = array.Length;
    for (int i = 0; i < arr; i++)
    {
        array[i] = new Random().Next(1, 16);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] arr = new int[18];
CreateArray(arr);
PrintArray(arr);
int oddindex = SumOddIndex(arr);
Console.WriteLine($"Сумма чисел на нечётных позициях {oddindex}");
