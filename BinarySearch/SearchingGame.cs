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

            for (int i = 0; i <= highBound; i++)
                _range[i] = i;
        } 

        public void GetStart() {
            int input;
            int high = _range.Length - 1;
            int low = 0;    
            do {
                int mid = (low + high) / 2;
                Console.WriteLine("The hidden number " + _range[mid]);

                do {
                    Console.WriteLine("1. This number is less then the hidden number");
                    Console.WriteLine("2. This number is bigger then the hidden number");
                    Console.WriteLine("3. This number is the hidden number");
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input != 1 && input != 2 && input != 3);

                if(input == 1) high = mid;
                else if (input == 2) low = mid + 1;
                else Console.WriteLine("Urrrrrraaaaaaaaaaaaa");

            } while (input != 3);
        }
    }
}
