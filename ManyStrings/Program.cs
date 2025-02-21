using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            Console.WriteLine($"2 casas: {xx:f2}");
            Console.WriteLine($"Percentagem com uma casa decimal: {xx:p1}");
            Console.WriteLine($"Hexadecimal: {ii:x}");
            Console.WriteLine($"Moeda: {ii:c}");

            string welcomeMessage = "\nHello my friend:";
            string playerName = "KR1PT1CS";
            char c1 = '\u20AD';
            string phrase = $"{welcomeMessage}\n Player: {playerName}\n Do your best\t{c1}";
            Console.WriteLine(phrase);

            int coins = 10;
            int coinsNeeded = 100;
            Console.WriteLine($"\nYou have {coins} dollars. You need ({coinsNeeded - coins}) more.");

            double amount = 1.111111;
            Console.WriteLine($"2 decimal places: {amount:f2}");
        }
    }
}