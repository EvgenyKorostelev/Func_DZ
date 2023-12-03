// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Func(string num)
{
    
    while(num != "q")
    {
        int numI = Convert.ToInt32(num);
        int numTTT = numI;
        int count = 0;
        while (numTTT != 0)
        {
            numTTT = numTTT / 10;
            count++;
        }
        
        int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = numI % 10;
            numI /= 10;
        }
        Console.WriteLine();

        int resulTT = 0;
        for(int m = 0; m < count; m++)
        {
            resulTT = resulTT + array[m];
        }
        Console.WriteLine($"Сумма цифр числа {num} равна: {resulTT}");
        
        int result = 1;
        result = resulTT % 2;
        if (result == 0)
        {
            break;
        }
        Console.WriteLine();
        Console.Write("Введите целое число: ");
        string numS = (Console.ReadLine()!); // ! значит что пустое значение вводится не будет
        num = numS;
        
    }
    Console.WriteLine("[STOP]");
}

Console.Write("Введите целое число: ");
string numV = (Console.ReadLine()!);  // ! значит что пустое значение вводится не будет

Func(numV);