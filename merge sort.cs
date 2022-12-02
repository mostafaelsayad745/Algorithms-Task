using System;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the size of the array : ");
            int x = Convert.ToInt32( Console.ReadLine());
            int[] arr = new int[x];
            Console.WriteLine("Enter the array : ");
            for (int i = 0; i < x; i++)
            {
                arr[i] = Console.Read();
                Console.Write(" ");
            }
            mergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void mergeSort(int[] arr , int firstIndex , int lastIndex)
        {
            if (lastIndex > firstIndex)
            {
                int midIndex = firstIndex+ (lastIndex-firstIndex) / 2;
                mergeSort(arr, firstIndex, midIndex);
                mergeSort(arr, midIndex + 1, lastIndex);
                merge(arr, firstIndex, lastIndex, midIndex);
            }
        }

        private static void merge(int[] arr, int f, int l, int m)
        {
            // size of the left array 
            int x = m - f + 1;
            // size of the right array 
            int y = l - m;

            int[] leftArray = new int[x];
            int[] rightArray = new int[y];

            int i, j;
            // Copy data to left and right arrays
            for ( i = 0; i < x; i++)
                leftArray[i] = arr[f + i];
            for ( j = 0; j < y; j++)
                rightArray[j] = arr[m + 1 + j];

            i = 0;
            j = 0;


           


            // comparing two elements in two arrays (right and left ) at the indexes (i , j )
            // then see the smaller one between them and put them in (arr )

            int k = f;
            while (i < x && j < y)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i]; i++;
                }
                else
                {
                    arr[k] = rightArray[j];j++;
                }
                k++;
            }
            //  if all the elements in the right array is all taken then take the elements in the left one
            while (i < x)
              arr[k] = leftArray[i]; i++; k++;

            //  if all the elements in the left array is all taken then take the elements in the right one
            while (j < y)
                arr[k] = rightArray[j]; j++; k++;
               

        }
    }
}
