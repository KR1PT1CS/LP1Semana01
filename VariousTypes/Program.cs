using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            short power = 7;
            int xp_needed = 1000000;
            long gold = 10000000000;
            Console.WriteLine($"Power: {power}, xp: {xp_needed}, gold: {gold}")

            char c1 = '\u20AD', c2 = '\u20AD' c3 = '\u20AD';
            Console.WriteLine($"\nChars: {c1} {c2} {c3}");
        }
    }
}
