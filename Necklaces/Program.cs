using System;

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

            Console.WriteLine($"\nResult: {GetGreatestNecklace(beads)}");
            Console.ReadKey();
        }

        static int GetGreatestNecklace(int[] b)
        {
            string necklaces = "!|";
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                int current = i;
                while (!necklaces.Contains("|" + current + "|"))
                {
                    necklaces += current + "|";
                    current = b[current];
                }
                count = Math.Max(count, necklaces.Substring(necklaces.LastIndexOf("!") + 1).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Length);
                necklaces += "!|"; 
            }
            return count;
        }
    }
}
