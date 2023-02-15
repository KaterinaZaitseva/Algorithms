using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes;
internal static class SieveOfEratosthenes
{
    public static List<int> FindPrimeNumbers(int n) {
        bool[] isPrime = new bool[n + 1];
        List<int> primeNumbers = new List<int>();
        Array.Fill(isPrime, true);

        for (int i = 2; i * i <= n; i++)
            if (isPrime[i])
                for (int j = i * i; j <= n; j += i)
                    isPrime[j] = false;

        for (int i = 2; i <= n; i++)
            if (isPrime[i])
                primeNumbers.Add(i);
        return primeNumbers;
    }

    // предположительно ты хотел, чтобы булевый массив начинался с нижней границы,
    // но я пока не придумала как это реализовать)
    public static List<int> FindPrimeNumbers(int leftBound, int rightBound) {
        List<int> primeNumbers = new List<int>();
        bool[] isPrime = new bool[rightBound + 1];
        Array.Fill(isPrime, true);

        for (int i = 2; i * i <= rightBound; i++)
            if (isPrime[i])
                for (int j = i * i; j <= rightBound; j += i)
                    isPrime[j] = false;

        for (int i = leftBound; i <= rightBound; i++)
            if (isPrime[i])
                primeNumbers.Add(i);
        return primeNumbers;
    }

}

