using System;

class Program
{
    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j]; 
                j = j - 1;
            }

            array[j + 1] = key; 
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] array = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

        Console.WriteLine("Array antes de ser ordenado:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("Array após o Insertion Sort:");
        PrintArray(array);
    }
}