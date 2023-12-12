using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        zad3();
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
    static void zad3()
    {
        Console.WriteLine("Введите три числа:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int[] array = { 6, 3, 3, 8, 19, 54, 2, 6, 7, 8, 5, 2, 1 };

        int count = 0;
        for (int i = 0; i < array.Length - 2; i++)
        {
            if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
            {
                count++;
            }
        }
        Console.WriteLine("Колличетво повторений в массиве " + count);
    }
    static void zad4()
    {
        int[] M = { 6, 3, 3, 8, 19, 54, 2, 6, 7, 8 };
        int[] N = { 6, 3, 4, 54, 18, 4, 4, 20, 4, 4, 56, 21, 1 };

        int num = 0;
        if(M.Length>N.Length) num = N.Length;
        else num = M.Length;

        int[] array = new int[num];
        for (int i = 0, arthree=0; i < M.Length; i++)
        {
            for (int j = 0; j < N.Length; j++)
            {
                if (M[i] == N[j])
                {
                    array[arthree] = M[i];
                }
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }


    }
}