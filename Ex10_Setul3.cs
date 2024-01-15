using System;

namespace Setul3Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
            //Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
            int[] numere = { 1, 2, 5, 8, 34, 56, 87 };
            int k = 5;

            int pozitie = cautareBinara(numere, k);
            if (pozitie != -1 )
            {
                Console.WriteLine($"Elementul {k} gasit pe pozitia {pozitie}.");
            }
            else
            {
                Console.WriteLine($"Elementul {k} nu este in vector.");
            }


        }
        static int cautareBinara(int[] arr, int k)
        {
            int stanga = 0;
            int dreapta = arr.Length - 1;
            while (stanga <= dreapta)
            {
                int mid = stanga + (dreapta - stanga) / 2;
                if (arr[mid] == k)
                {
                    return mid;
                }
                if (arr[mid] < k)
                {
                    stanga = mid + 1;
                }
                else
                {
                    dreapta = mid - 1;
                }
            }
            return -1;
        }
    }
}