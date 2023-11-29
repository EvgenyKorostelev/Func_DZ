// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

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
    int[] newArray = new int[array.Length];
    int j = 0;
    for(int i = array.Length - 1; i >= 0; i--)
    {
        newArray[j] = array[i];
        j++;    
    }
    PrintArray(newArray);
}



Console.Write("Enter array size: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array min: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array max: ");
int mx = Convert.ToInt32(Console.ReadLine());


int [] arr = CreateArray(mn, mx, s);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Перевернутый массив:");
Func(arr);