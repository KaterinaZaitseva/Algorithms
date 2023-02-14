namespace SieveOfEratosthenes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the range: ");
            int input = Convert.ToInt32(Console.ReadLine());
            SieveOfEratosthenes.FindPrimeNumbers(input);
        }
    }
}
