namespace FindingTheLargestCommonSubstring;
internal class Program {
    public static void Main(string[] args) {
        FindingCommonSubstring a = new FindingCommonSubstring("aaaaadfffshehjkl", "dddshehd");
        Console.WriteLine(a.GetSubstring("aaaaadfffshehjkl", "sheh"));
        Console.WriteLine(a.FindMaxCommonSubstring());
    }

}