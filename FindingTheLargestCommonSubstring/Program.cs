namespace FindingTheLargestCommonSubstring;
internal class Program {
    public static void Main(string[] args) {
        FindingCommonSubstring a = new FindingCommonSubstring("aaaaadfffshehjkl", "dddshehщ");
        Console.WriteLine(a.FindMaxCommonSubstring(true));
    }

}