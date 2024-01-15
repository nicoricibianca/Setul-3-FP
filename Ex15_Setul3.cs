using System;
using System.Collections.Generic;

namespace Setul3Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
            List<int> numere = new List<int>() { 1, 1, 2, 2, 2, 3, 4, 5, 6, 6 };
            Console.WriteLine("Lista originala: ");
            PrintList(numere);

            EliminareaElementelorRepetate(numere);
            Console.WriteLine("Lista dupa eliminarea elementelor care se repeta: ");
            PrintList(numere);
            
        }
        static void EliminareaElementelorRepetate(List<int> numere)
        {
            for (int i = numere.Count - 1; i >= 0; i--)
            {
                int valoareCurenta = numere[i];

                if (numere.IndexOf(valoareCurenta) < i)
                {
                    numere.RemoveAt(i);
                }
            }
        }
        static void PrintList(List<int> numere)
        {
            foreach (int num in numere)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}