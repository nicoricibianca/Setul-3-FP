using System;

namespace Setul3Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
            int[] v1 = { 2, 4, 5, 6, 8 };
            int[] v2 = { 2, 4, 5, 7, 8 };

            HashSet<int> setV1 = new HashSet<int>(v1);
            HashSet<int> setV2 = new HashSet<int>(v2);

            IEnumerable<int> intersectie = setV1.Intersect(setV2);

            IEnumerable<int> reuniunea = setV1.Union(setV2);

            IEnumerable<int> diferentaV1V2 = setV1.Except(setV2);

            IEnumerable<int> diferentaV2V1 = setV2.Except(setV1);

            Console.WriteLine(" Intersectia: ");
            foreach (int valoare in intersectie)
            {
                Console.Write(valoare + " ");
            }

            Console.WriteLine("\n\n Reuniunea: ");
            foreach (int valoare in reuniunea)
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
            Console.ReadKey();

        }
    }
}