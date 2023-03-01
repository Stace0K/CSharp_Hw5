// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void CreateArray(double[] array)
{
    int arr = array.Length;
    for (int i = 0; i < arr; i++)
    {
        array[i] = new Random().Next(1, 9) + new Random().NextDouble();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double[] arr = new double[11];
CreateArray(arr);
PrintArray(arr);
double max = Max(arr);
double min = Min(arr);
Console.WriteLine($"{max} - {min} = {max - min}");