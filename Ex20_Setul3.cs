using System;

namespace Setul3Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.
            //Siragurile de margele se pot roti atunci cand le suprapunem. 
            string s1 = "NANNAN";
            string s2 = "ANANAN";
            int margeleSuprapuse = MargeleSuprapuse(s1, s2);
            Console.WriteLine($"Numarul de suprapuneri este: {margeleSuprapuse}");

        }
        static int MargeleSuprapuse(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                throw new ArgumentException("String-urile trebuie sa aiba aceiasi lungime.");
            }

            int count = 0;
            int n = s1.Length;
            string s1Concatenata = s1 + s1;

            for (int i = 0; i < n; i++)
            {
                int matchingCount = 0;

                for (int j = 0; j < n; j++)
                {
                    if (s1Concatenata[i + j] == s2[j])
                    {
                        matchingCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (matchingCount == n)
                {
                    count++;
                }
            }
            return count;
        }
    }
}