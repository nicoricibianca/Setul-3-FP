using System;

namespace Setul3Ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie).
            //Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
            List<int> num1 = new List<int>() { 9, 9, 9, 9, 9 };
            List<int> num2 = new List<int>() { 1, 2, 3 };
            List<int> suma = AdunareaNumerelorFoarteMari(num1, num2);

            Console.WriteLine("Suma: ");
            foreach (int cifra in suma)
            {
                Console.Write(cifra);
            }

            Console.ReadKey();
        }
        static List<int> AdunareaNumerelorFoarteMari(List<int> num1, List<int> num2)
        {
            List<int> rezultat = new List<int>();
            int rest = 0;
            int i = num1.Count - 1;
            int j = num2.Count - 1;

            while (i >= 0 || j >= 0 || rest > 0)
            {
                int cifra1 = i >= 0 ? num1[i] : 0;
                int cifra2 = j >= 0 ? num2[j] : 0;
                int suma = cifra1 + cifra2 + rest;
                rest = suma / 10;
                rezultat.Add(suma % 10);

                i--;
                j--;
            }
            rezultat.Reverse();
            return rezultat;
        }
    }
}