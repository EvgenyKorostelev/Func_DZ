// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void Func(string num)
{
    int result = 1;
    while(num != "q" | result != 0)
    {
        Console.Write("Введите целое число: ");
        string numS = Console.ReadLine();
        Console.WriteLine();
        num = numS;
                
        int numI = Convert.ToInt32(numS);
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

        for(int j = count - 1; j >= 0; j--)
        {
            Console.Write(array[j] + " ");
        }
        
        int resulTT = 0;
        for(int m = 0; m < count; m++)
        {
            resulTT = resulTT + array[m];
        }
        result = resulTT % 2;
    }

}

Console.Write("Введите целое число: ");
string numV = (Console.ReadLine());

Func(numV);