using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch{
    internal class SearchingGame {
        private int[] _range;

        public SearchingGame(int highBound) {
            _range = new int[highBound + 1];

            for (int i = 1; i <= highBound; i++)
                _range[i] = i;
        }

        public void GetStart()
        {
            int input;
            int high = _range.Length - 1;
            int low = 0;
            int guess;
            int mid = 0;
            while (low <= high) {
                mid = (low + high) / 2;
                guess = _range[mid];
                do {
                    Console.WriteLine("The supposed number is " + guess);
                    Console.WriteLine("1. This number is less then the hidden number");
                    Console.WriteLine("2. This number is bigger or equal to then the hidden number");
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input != 1 && input != 2);
                if (input == 1)
                    high = mid - 1;

                else if (input == 2)
                    low = mid;
            }
            Console.WriteLine("The hidden number " + _range[mid]);
        }
    }
}
