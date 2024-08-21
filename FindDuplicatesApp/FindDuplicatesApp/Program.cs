using System;
using System.Collections.Generic;

namespace FindDuplicatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            int[] inputArray = { 1, 2, 3, 1, 2, 3 };
            int[] duplicates = FindDuplicates(inputArray);

            Console.WriteLine("Duplicates:");
            foreach (int value in duplicates)
            {
                Console.Write(value + " ");
            }
        }

        static int[] FindDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicatesSeen = new HashSet<int>();

            foreach (int value in arr)
            {
                if (seen.Contains(value))
                {
                    if (!duplicatesSeen.Contains(value))
                    {
                        duplicates.Add(value);
                        duplicatesSeen.Add(value);
                    }
                }
                else
                {
                    seen.Add(value);
                }
            }

            return duplicates.ToArray();
        }
    }
}
