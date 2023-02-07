using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ArithmeticProgression arithmeticProgression = new ArithmeticProgression(a1, d);
            Console.WriteLine("Sum through a cycle: " + arithmeticProgression.CalculateSumThroughCycle(n));
            Console.WriteLine("Sum through a formula: " + arithmeticProgression.CalculateSumThroughFormula(n));
        }
    }
}
