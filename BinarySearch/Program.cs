namespace BinarySearch {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Enter the range: ");
            int input = Convert.ToInt32(Console.ReadLine());
            SearchingGame.GetStart(input);
        }
    }
}

