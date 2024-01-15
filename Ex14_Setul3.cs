using System;

namespace Setul3Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
            //(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).
            int[] vector = { 0, 1, 2, 0, 6, 0, 0, 7, 8, 0 };
            Console.WriteLine("Vectorul original: ");
            foreach (int num in vector)
            { 
                Console.Write(num + " ");
            }
            Console.WriteLine();

            ZeroLaFinal(vector);
            Console.WriteLine("Vectorul ordonat: ");
            foreach(int num in vector)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void ZeroLaFinal(int[] vector)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;

            while (stanga < dreapta)
            {
                while (stanga < dreapta && vector[stanga] != 0)
                {
                    stanga++;
                } 
            }
            while (stanga < dreapta && vector[dreapta] == 0)
            {
                dreapta--;
            }
            if (stanga < dreapta)
            {
                int temp = vector[stanga];
                vector[stanga] = vector[dreapta];
                vector[dreapta] = temp;
                stanga++;
                dreapta--;

            }
        }
    }
}