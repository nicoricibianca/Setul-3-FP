using System;

namespace Setul3Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
            int[] numere = { 34, 28, 88, 46 };
            int rezultat = CalculCmmdc(numere);
            Console.WriteLine($"Cel mai mare divizor comun al vectorului este: {rezultat}. ");

        }
        static int CalculCmmdc(int[] numere)
        {
            int rezultat = numere[0];

            for (int i = 1; i < numere.Length; i++)
            {
                rezultat = Cmmdc(rezultat, numere[i]);
            }
            return rezultat;
        }
        static int Cmmdc(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}