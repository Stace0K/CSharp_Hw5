// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Number(string figure)
{
    Console.Write(figure);
    string matter = Console.ReadLine();
    int result = Convert.ToInt32(matter);
    return result;
}

int[] CreateArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int EvenNumber(int[] array)
{
    int even = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k] % 2 == 0)
        {
            even = even + 1;
        }
    }
    return even;
}

int n = Number("Длина массива: ");
int[] mass = CreateArray(n);
PrintArray(mass);
int even = EvenNumber(mass);
Console.WriteLine($"Чётных чисел в данном массиве {even}.");


