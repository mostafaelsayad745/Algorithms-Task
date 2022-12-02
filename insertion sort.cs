using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 7, 6, 8, 3, 9, 4 };
            InsertionSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static int[] InsertionSort (int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
