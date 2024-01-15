using System;
using System.Numerics;

namespace Setul3Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
            //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 

            List<int> vector = new List<int>() { 1, 2, 3, 4, 5 };
            int k = 2;
            
            if (k >= 0 && k < vector.Count)
            {
                vector.RemoveAt(k);
                Console.WriteLine($"Elementul de pe pozitia {k} a fost sters. ");
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