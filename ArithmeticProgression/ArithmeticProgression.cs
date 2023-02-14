using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    internal class ArithmeticProgression {

        private int _firstElement;
        private int _difference;

        public ArithmeticProgression() {
            _firstElement = 0;
            _difference = 0;
        }

        public ArithmeticProgression(int firstElement, int difference) {
            _firstElement = firstElement;
            _difference = difference;
        }

        public int CalculateNthTerm(int n) {
            return _firstElement + (n - 1) * _difference;
        }

        public int CalculateSumThroughCycle(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += CalculateNthTerm(i);
            return sum;
        }

        public int CalculateSumThroughFormula(int n) {
            return (2 * _firstElement + (n - 1) * _difference) * n / 2;
        }

    }
}
