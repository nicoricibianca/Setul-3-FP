using System;

class Program
{
    static void Main()
    {
        //Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 

        int[] vector1 = { 1, 2, 3 };
        int[] vector2 = { 1, 2, 4 };

        int rezultatComparare = ComparareVectori(vector1, vector2);

        if (rezultatComparare < 0)
        {
            Console.WriteLine("Primul vector apare primul in ordine lexicografica.");
        }
        else if (rezultatComparare > 0)
        {
            Console.WriteLine("Vectorul 2 apare primul in ordine lexicografica.");
        }
        else
        {
            Console.WriteLine("Ambii vectori au aceiasi ordine lexicografica.");
        }
    }
    static int ComparareVectori(int[] vector1, int[] vector2)
    {
        int minLength = Math.Min(vector1.Length, vector2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (vector1[i] < vector2[i])
            {
                return -1; 
            }
            else if (vector1[i] > vector2[i])
            {
                return 1; 
            }
        }

        
        if (vector1.Length < vector2.Length)
        {
            return -1;
        }
        else if (vector1.Length > vector2.Length)
        {
            return 1;
        }
        else
        {
            return 0; 
        }
    }

    
}
