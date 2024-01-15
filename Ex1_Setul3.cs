using System;

namespace Setul3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

            Console.WriteLine("Scrieti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());

            double[] numere = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numar {i + 1}: ");
                numere[i] = double.Parse(Console.ReadLine());
            }

            double suma = 0;

            foreach (double num in numere)
            {
                suma += num;
            }

            Console.WriteLine($"Suma numerelor este: {suma}.");
        }
    }
}