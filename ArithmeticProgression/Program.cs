using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Enter a first element: ");
            int firstElement = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a difference: ");
            int difference = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a count: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ArithmeticProgression arithmeticProgression = new ArithmeticProgression(firstElement, difference);
            Console.WriteLine("Sum through a cycle: " + arithmeticProgression.CalculateSumThroughCycle(n));
            Console.WriteLine("Sum through a formula: " + arithmeticProgression.CalculateSumThroughFormula(n));
        }
    }
}
