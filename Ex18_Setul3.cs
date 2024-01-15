using System;

namespace Setul3Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
            //Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
            double[] coeficienti = { 2, -3, 0, 5 };
            double x = 2.5;
            double rezultat = Polinom(coeficienti, x);
            Console.WriteLine($"Valoarea polinomului la x = {x} este: {rezultat}.");

        }
        static double Polinom(double[] coeficienti, double x) 
        { 
            int n = coeficienti.Length;
            double rezultat = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                rezultat = rezultat * x + coeficienti[i];
            }
            return rezultat;
        }
    }
}