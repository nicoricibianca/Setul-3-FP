using Microsoft.VisualBasic;
using System;

namespace Setul3Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
            int[] v1 = { 0, 0, 1, 0, 1, 0, 1, 0 };
            int[] v2 = { 0, 0, 1, 1, 0, 0, 1, 0 };

            IEnumerable<int> setV1 = v1.Select((val, index) => new { val, index }).Where(item => item.val == 1).Select(item => item.index);
            IEnumerable<int> setV2 = v2.Select((val, index) => new { val, index }).Where(item => item.val == 1).Select(item => item.index);

            HashSet<int> hashSetV1 = new HashSet<int>(setV1);
            HashSet<int> hashSetV2 = new HashSet<int>(setV2);

            IEnumerable<int> intersectie = hashSetV1.Intersect(hashSetV2);
            
            IEnumerable<int> reuniune = hashSetV1.Union(hashSetV2);

            IEnumerable<int> diferentaV1V2 = hashSetV1.Except(hashSetV2);

            IEnumerable<int> diferentaV2V1 = hashSetV2.Except(hashSetV1);

            Console.WriteLine(" Intersectia:");
            foreach (int value in intersectie)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\n Reuniunea:");
            foreach (int value in reuniune)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\n Diferenta v1 si v2: ");
            foreach (int value in diferentaV1V2)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\n Diferenta v2 si v1: ");
            foreach (int value in diferentaV2V1)
            {
                Console.Write(value + " ");
            }

            Console.ReadKey();

        }
    }
}