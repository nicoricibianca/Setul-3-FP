using System;

namespace Setul3Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
            Console.WriteLine("Dati un numar natural n: ");
            int n = int.Parse(Console.ReadLine());

            CiurulLuiEratostene(n);

        }

        static void CiurulLuiEratostene(int n)
        {
            bool[] nrPrime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                nrPrime[i] = true;
            }
            nrPrime[0] = nrPrime[1] = false;

            for (int p = 2; p * p <= n; p++)
            {
                if (nrPrime[p] == true) 
                { 
                    for (int i = p * p; i <= n; i++)
                    {
                        nrPrime[i] = false;
                    }
                }
            }
            Console.WriteLine($"Numerele prime pana la {n} sunt: ");
            for (int i = 2; i <= n; i++)
            {
                if (nrPrime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}