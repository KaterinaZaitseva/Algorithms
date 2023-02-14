namespace NumericalRepresentation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] arr = { 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0};
            BinaryRepresentation num = new BinaryRepresentation(arr);
            Console.WriteLine(num.ToString());                   // 11101010011100
            Console.WriteLine(num.ToString(30));                 // 000000000000000011101010011100
            Console.WriteLine(Converter.ConvertBinToDec(num));   // 15004
            Console.WriteLine(Converter.ConvertBinToOct(num));   // 35234
            Console.WriteLine(Converter.ConvertBinToHex(num));   // 3A9C
            Console.WriteLine(Converter.ConvertDecToBin(335));   // 101001111
            Console.WriteLine(Converter.ConvertDecToBin(289));   // 100100001
            Console.WriteLine(Converter.ConvertDecToBin(11009)); // 10101100000001
        }
    }
}