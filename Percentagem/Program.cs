using System;

namespace Percentagem
class Program
{
    static void Main()
    {
        double[] numeros = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite número {i + 1}: ");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
            
            while (numeros[i] < 0 || numeros[i] > 1)
            {
                Console.Write("Número inválido! Digite entre 0 e 1: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine("------------------------");
        
        foreach (double n in numeros)
        {
            Console.WriteLine($"{n,10:F7} | {n,11:P2}");
        }
        Console.WriteLine("------------------------");
    }
}
            
          






