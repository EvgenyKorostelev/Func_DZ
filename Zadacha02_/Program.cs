// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу,которая покажет количество чётных чисел в
// массиве.

int [] CreateArray(int min, int max, int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Func(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++; 
    }
    Console.Write($"Количество четных чисел в массиве: {count}");
}

Console.Write("Enter array size: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array min: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array max: ");
int mx = Convert.ToInt32(Console.ReadLine());


int [] arr = CreateArray(mn, mx, s);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Func(arr);