using System;
using System.Diagnostics;
using System.IO;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string path = @"data.txt";
            string[] lines = File.ReadAllLines(path);

            int[] numbers = new int[lines.Length];
            int[] secNumber = new int[lines.Length];
            

            for(int i = 0; i < lines.Length; i++)
            {
                numbers[i] = Convert.ToInt32(lines[i]);
                secNumber[i] = Convert.ToInt32(lines[i]);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //Our implementation of Quicksort
            //QuickSort(numbers, 0, lines.Length - 1);

            //Microsoft's built in Quicksort
            //Array.Sort(secNumber);

            sw.Stop();

            Console.WriteLine("Elapsed time in ms: {0}", sw.Elapsed);

        }

                
        static void QuickSort(int[] numbers, int low, int high)
        {
            
            if (low < high)
            {
                int pi = partition(numbers, low, high);

                QuickSort(numbers, low, pi - 1);
                QuickSort(numbers, pi + 1, high);
            }
        }
        
        static int partition(int[] numbers, int low, int high)
        {
            
            int pivot = numbers[high];


            int i = low - 1;

            for(int j = low; j < high; j++)
            {
                if(numbers[j] < pivot)
                {
                    i++;
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            int temp1 = numbers[i + 1];
            numbers[i + 1] = numbers[high];
            numbers[high] = temp1;

            return i + 1;
        }


    }
}
