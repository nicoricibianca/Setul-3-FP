using System;
using System.Linq;

namespace Setul3Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
            List<int> vector = new List<int> {1, 1, 3, 45, 45, 7, 5, 45, 23 };
            int celMaiMic = vector.Min();
            int celMaiMare = vector.Max();

            int celMaiMicCount = vector.Count(num => num == celMaiMic);
            int celMaiMareCount = vector.Count(num => num == celMaiMare);

            Console.WriteLine($"Cel mai mic numar este {celMaiMic} si apare de {celMaiMicCount} ori.");
            Console.WriteLine($"Cel mai mare numar este {celMaiMare} si apare de {celMaiMareCount} ori.");


        }
    }
}