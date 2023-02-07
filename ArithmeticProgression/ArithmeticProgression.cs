using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ArithmeticProgression
    {
        private int _a1;
        private int _d;

        public ArithmeticProgression()
        {
            _a1 = 0;
            _d = 0;
        }

        public ArithmeticProgression(int a1, int d)
        {
            _a1 = a1;
            _d = d;
        }

        public int CalculateNthTerm(int n)
        {
            return _a1 + (n - 1) * _d;
        }

        public int CalculateSumThroughCycle(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += CalculateNthTerm(i);
            return sum;
        }

        public int CalculateSumThroughFormula(int n)
        {
            return (2 * _a1 + (n - 1) * _d) * n / 2;
        }

    }
}
