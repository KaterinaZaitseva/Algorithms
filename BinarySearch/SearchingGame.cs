using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch{
    internal static class SearchingGame {

        public static void GetStart(int highBound) {
            int input;
            int high = highBound;
            int low = 0;
            int guess = 0;
            int mid = 0;

            while(low < high) {
                mid = (low + high) / 2;
                guess = mid;
                do {
                    Console.WriteLine("The supposed number is " + guess);
                    Console.WriteLine("1. This number is less then the hidden number");
                    Console.WriteLine("2. This number is bigger or equal to then the hidden number");
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input != 1 && input != 2);

                if (input == 1)
                    high = mid - 1;

                else if (input == 2)
                    low = mid + 1;
            }

            Console.WriteLine("The hidden number " + high);
        }

    }
}
