using System;

namespace Setul3Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Interclasare) Se dau doi vector sortati crescator v1 si v2.
            //Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
            int[] v1 = { 1, 3, 5, 7, 9 };
            int[] v2 = { 2, 4, 6, 8, 10 };
            List<int> elementeCombinate = VectorulTrei(v1, v2);

            Console.WriteLine("Vectorul trei: ");
            foreach (int elemente in elementeCombinate)
            {
                Console.Write(elemente + " ");
            }
            Console.ReadKey();

        }
        static List<int> VectorulTrei(int[] v1, int[] v2)
        {
            List<int> elementeCombinate = new List<int>();
            int v1Length = v1.Length;
            int v2Length = v2.Length;
            int i = 0; int j = 0;

            while (i < v1Length && j < v2Length)
            {
                if (v1[i] <= v2[j])
                {
                    elementeCombinate.Add(v1[i]);
                    i++;
                }
                else
                {
                    elementeCombinate.Add(v2[j]);
                    j++;
                }
            }
            while (i < v1Length)
            {
                elementeCombinate.Add(v1[i]);
                i++;
            }
            while (j < v2Length)
            {
                elementeCombinate.Add(v2[j]);
                j++;
            }
            return elementeCombinate;
        }
    }
}