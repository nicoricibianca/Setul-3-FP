using System;

namespace Setul3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.
            //Daca k nu apare in vector rezultatul va fi -1. 
            int[] numere = { 2, 5, 7, 9, 3, 5 };
            int k = 9;

            int pozitie = Pozitia(numere,k);

            if (pozitie != -1) 
            {
                Console.WriteLine($"Pozitia lui k este: {pozitie}.");
            }
            else
            {
                Console.WriteLine("K nu este in vector.");
            }


        }

        static int Pozitia(int[] vector, int k)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == k)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}