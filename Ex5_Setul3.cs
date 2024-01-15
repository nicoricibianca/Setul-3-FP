using System;

namespace Setul3Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.

            List<int> vector = new List<int>() { 1, 2, 3, 4, 5 };

            int e = 10;
            int k = 2;

            if (k >= 0 && k <= vector.Count)
            {
                vector.Insert(k, e);
               
            }
            else
            {
                Console.WriteLine("Pozitie invalida.");
            }

            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
        }
    }
}