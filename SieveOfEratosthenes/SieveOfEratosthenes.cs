using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    internal static class SieveOfEratosthenes
    {
        public static void FindPrimeNumbers(int n) {
            bool[] isPrime = new bool[n];
            Array.Fill(isPrime, true);

            for (int i = 2; i * i < n; i++)
                if (isPrime[i])
                    for (int j = i * i; j < n; j += i)
                        isPrime[j] = false;

            for (int i = 2; i < n; i++)
                if (isPrime[i])
                    Console.Write(i + " ");
        }
    }
}
