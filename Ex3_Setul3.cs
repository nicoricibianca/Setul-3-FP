using System;

namespace Setul3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

            int minIndex = vector.ToList().IndexOf(vector.Min());
            int maxIndex = vector.ToList().IndexOf(vector.Max());

            Console.WriteLine($"Pozitia celui mai mic element din vector este {minIndex}, pozitia celui mai mare element din vector este {maxIndex}.");
        }
    }
}