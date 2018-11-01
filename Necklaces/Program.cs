using System;
using System.Collections.Generic;

namespace Necklaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] beads = new int[] { 7, 2, 4, 0, 5, 6, 1, 3 };
            foreach (var bead in beads)
            {
                Console.Write(bead + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nMax length: {GetGreatestNecklace(beads)}");
            Console.ReadKey();
        }

        static int GetGreatestNecklace(int[] b)
        {
            List<int> beads = new List<int>();
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                int current = i;
                int localCount = 0;
                if (!beads.Contains(current))
                {                
                    while (!beads.Contains(current))
                    {
                        beads.Add(current);
                        current = b[current];
                        localCount++;
                    }
                    beads.Add(current);
                    count = Math.Max(count, localCount);
                }
            }
            Console.WriteLine("Result necklace");
            foreach (var item in beads)
            {
                Console.Write(item + " ");
            }
            return count;
        }
    }
}
