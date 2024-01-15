using System;

namespace Setul3Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.  
            Console.WriteLine("Dati un numar : ");
            int numar = int.Parse(Console.ReadLine());
            int baza = 8;

            string rezultat = Convert(numar, baza);
            Console.WriteLine($"Numarul {numar} in baza {baza} este: {rezultat}.");

        }
        static string Convert(int n, int b)
        {
            if (n == 0)
            {
                return "0";
            }

            char[] cifre = "0123456789ABCDEF".ToCharArray();
            string rezultat = string.Empty;

            while (n > 0)
            {
                int rest = n % b;

                rezultat = cifre[rest] + rezultat;

                n /= b;
            }
            return rezultat;
        }
    }
}