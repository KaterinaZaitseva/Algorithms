namespace FindingTheLargestCommonSubstring;
internal class Program {
    public static void Main(string[] args) {
        FindingCommonSubstring a = new FindingCommonSubstring("selfish", "fisherman");
        FindingCommonSubstring b = new FindingCommonSubstring("instruction", "onion");
        FindingCommonSubstring c = new FindingCommonSubstring("ironic", "saphir");
        FindingCommonSubstring d = new FindingCommonSubstring("irregardless ", "successful");
        FindingCommonSubstring e = new FindingCommonSubstring("disappoint", "cruel");

        Console.WriteLine(a.FindMaxCommonSubstring(true));  // fish
        Console.WriteLine(b.FindMaxCommonSubstring(false)); // ion
        Console.WriteLine(c.FindMaxCommonSubstring(true));  // ir
        Console.WriteLine(d.FindMaxCommonSubstring(false)); // ess
        Console.WriteLine(e.FindMaxCommonSubstring(true));  // 
    }

}