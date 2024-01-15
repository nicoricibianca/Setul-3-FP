using System;

namespace Setul3Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
            int[] numere = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Array.Reverse(numere);

            foreach (int num in numere)
            {
            Console.Write(num + " ");
            }
        }
    }
}