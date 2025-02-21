using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string welcomeMessage = "Hello my friend:";
            string playerName = "Txger";
            char c1 = '\u2623', c2 = '\u26A1';
            string phrase = $"{welcomeMessage}\n Player: {playerName}\n Do your best\t{c2}";
            Console.WriteLine(phrase);

            int coins = 10;
            int coinsNeeded = 100;
            Console.WriteLine($"You have {coins} dollars. You need ({coinsNeeded} - {xp}) more.");

            double amount = 1.111111;
            Console.WriteLine($"2 decimal places: {amount:f2}");

            int a = 3;
            int b = 7;
            Console.WriteLine($"{a} + {b} is equal to {a + b}.");
            Console.WriteLine($"The value of x is {a} and the value of y is {b}.");
        }
    }
}