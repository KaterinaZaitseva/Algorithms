namespace NumericalRepresentation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] arr = { 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0};
            BinaryRepresentation num = new BinaryRepresentation(arr);
            Console.WriteLine(num.ToString());
            Console.WriteLine(Converter.ConvertBinToDec(num));
            Console.WriteLine(Converter.ConvertBinToOct(num));
            Console.WriteLine(Converter.ConvertBinToHex(num));
            Console.WriteLine(Converter.ConvertDecToBin(335));
        }
    }
}