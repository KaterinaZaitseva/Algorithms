using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixSum {
    internal class PrefixSum {

        private int[] _numbers;
        private long[] _prefixSums;

        public PrefixSum() {
            RandomInitialization();
            _prefixSums = new long[_numbers.Length];
            CalculatePrefixSum();
        }

        public PrefixSum(int[] numbers, int numberOfQuery) {
            _numbers = numbers;
            _prefixSums = new long[_numbers.Length];
            CalculatePrefixSum();
        }

        private void RandomInitialization() {
            Random rnd = new Random();
            _numbers = new int[rnd.Next(20, 51)];
            
            for(int i = 0; i < _numbers.Length; i++)
                _numbers[i] = rnd.Next(0, 100);
        }

        private void CalculatePrefixSum() {
            _prefixSums[0] = _numbers[0];
            for(int i = 1; i < _numbers.Length; i++) 
                _prefixSums[i] = _prefixSums[i - 1] + _numbers[i];
        }

        private long QuerySum(int l, int r) {
            if(l > 0) return _prefixSums[r] - _prefixSums[l - 1];
            else return _prefixSums[r];
        }

        public long QuerySum(Range range) {
            return QuerySum(range.Start.Value, range.End.Value);
        }

        public long QuerySum() {
            return QuerySum(0..(_numbers.Length - 1));
        }

    }
}
