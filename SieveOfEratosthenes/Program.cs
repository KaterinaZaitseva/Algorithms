namespace SieveOfEratosthenes;
internal class Program { 
    public static void Main(string[] args) {
        List<int> result = new List<int>();
        result = SieveOfEratosthenes.FindPrimeNumbers(101); 

        foreach (int prime in result)
            Console.Write(prime + " "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101

        Console.WriteLine();

        result = SieveOfEratosthenes.FindPrimeNumbers(5, 13);

        foreach (int prime in result)
            Console.Write(prime + " "); // 5 7 11 13
    }
}

