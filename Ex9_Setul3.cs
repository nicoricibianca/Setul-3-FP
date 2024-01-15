using System;

namespace Setul3Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
            List<int> vector = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            int k = 2;

            Console.WriteLine("Vector original: ");
            foreach (int i in vector)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            RotireStanga(vector, k);
            Console.WriteLine($"Vectorul rotit de {k} ori: ");
            foreach (int i in vector)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }

        static void RotireStanga(List<int> vector, int k )
        {
            int n = vector.Count;
            k = k % n;

            List<int> rotata = new List<int>(n);

            for (int i = k; i < n; i++)
            {
                rotata.Add(vector[i]);
            }

            for (int i = 0; i < k; i++)
            {
                vector[i] = rotata[i];
            }
        }
    }
}