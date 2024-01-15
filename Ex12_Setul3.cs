using System;

namespace Setul3Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.
            int[] vectorDeSortat = { 54, 12, 4, 78, 67, 9 };
            Console.WriteLine("Vectorul inainte sa fie sortat: ");
            PrintVector(vectorDeSortat);

            SortareSelectie(vectorDeSortat);
            Console.WriteLine("Vectorul dupa sortare: ");
            PrintVector(vectorDeSortat);
            
        }
        static void SortareSelectie(int[] vector)
        {
            int n = vector.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = vector[minIndex];
                vector[minIndex] = vector[i];
                vector[i] = temp;
            }
        }
        static void PrintVector(int[] vector)
        {
            foreach (int num in vector)
            {
                Console.Write
                    (num + " ");
            }
            Console.WriteLine();
        }
    }
}