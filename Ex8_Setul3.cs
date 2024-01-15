using System;

namespace Setul3Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
            //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
            int[] numere = { 1, 2, 3, 4, 5 };

            int startIndex = 0;
            int endIndex = numere.Length - 1;

            while (startIndex < endIndex)
            {
                int temp = numere[startIndex];
                numere[startIndex] = numere[endIndex];
                numere[endIndex] = temp;

                startIndex++;
                endIndex--;
            }

            foreach (int num in numere)
            {
                Console.Write(num + " ");
            }
        }
    }
}