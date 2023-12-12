using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        zad2();
    }
    static void zad1()
    {
        int[] array = { 6, 3, 3, 8, 19, 54, 2, 6, 7, 8, 5, 2, 1 };

        int evenCount = 0;
        int oddCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
            else if (array[i] % 2 != 0)
            {
                oddCount++;
            }
        }



        Console.WriteLine("Четных элементов: " + evenCount);
        Console.WriteLine("Нечетных элементов: " + oddCount);

        Console.ReadLine();
    }
    static void zad2()
    {
        int num=int.Parse(Console.ReadLine());
        int[] array = { 6, 3, 3, 8, 19, 54, 2, 6, 7, 8, 5, 2, 1 };
        int evenCount = 0;
        for(int i = 0;i<array.Length; i++)
        {
            if (array[i] < num)
            {
                evenCount++;
            }
        }
        Console.WriteLine("Ввел пользователь " + num );
        Console.WriteLine(evenCount + "");
    }
}