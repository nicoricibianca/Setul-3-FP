using System;

namespace Setul3Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi).
            //Elementele care se repeta vor fi scrise o singura data in rezultat. 
            int[] v1 = { 2, 4, 4, 5, 6, 6, 8 };
            int[] v2 = { 2, 4, 5, 5, 7, 8, 8 };

            HashSet<int> setV1 = new HashSet<int>(v1);
            HashSet<int> setV2 = new HashSet<int>(v2);

            IEnumerable<int> intersectie = setV1.Intersect(setV2);

            IEnumerable<int> reuniune = setV1.Union(setV2);

            IEnumerable<int> diferentaV1V2 = setV1.Except(setV2);

            IEnumerable<int> diferentaV2V1 = setV2.Except(setV1);

            Console.WriteLine(" Intersectia: ");
            foreach (int valoare in intersectie)
            {
                Console.Write(valoare + " ");
            }

            Console.WriteLine("\n\n Reuniunea: ");
            foreach (int valoare in reuniune)
            {
                Console.Write(valoare + " ");
            }

            Console.WriteLine("\n\n Diferenta dintre v1 si v2: ");
            foreach (int valoare in diferentaV1V2)
            {
                Console.Write(valoare + " ");
            }

            Console.WriteLine("\n\n Diferenta dintre v2 si v1: ");
            foreach (int valoare in diferentaV2V1)
            {
                Console.Write(valoare + " ");
            }
        }
    }
}