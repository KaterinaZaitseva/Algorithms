namespace PrefixSum;
internal class Program {
    public static void Main(string[] args) {
        PrefixSum ps = new PrefixSum();
        StartCalculateQueries(ps);
    }
    private static void StartCalculateQueries(PrefixSum ps) {
        Console.WriteLine("\nEnter a right and left bounds (enter 'stop' to exit)");
        string[] leftAndRight;
        string? input = Console.ReadLine();

        while(input != "stop") {
            if(input != null) {
                leftAndRight = input.Split(' ');
                Console.WriteLine(ps.QuerySum(Int32.Parse(leftAndRight[0])..Int32.Parse(leftAndRight[1])));
            }
            input = Console.ReadLine();
        }
    }
}