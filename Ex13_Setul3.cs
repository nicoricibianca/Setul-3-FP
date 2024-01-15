using System;

namespace Setul3Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
            int[] vector = { 45, 3, 52, 34, 7, 4, 99 };
            InsertionSort(vector);
            Console.WriteLine("Vectorul sortat: ");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
        }
        static void InsertionSort(int[] vector)
        {
            int n = vector.Length;  

            for (int i = 1; i < n; ++i)
            {
                int k = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > k)
                {
                    vector[j + 1] = vector[j];
                    j = j - 1;
                }
                vector[j + 1] = k;
            }

        }

    }
}