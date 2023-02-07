namespace NumericalRepresentation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0 };
            BinaryRepresentation num = new BinaryRepresentation(arr);
            Console.WriteLine(Converter.ConvertBinToDec(num));
            Console.WriteLine(Converter.ConvertBinToOct(num));
            Console.WriteLine(Converter.ConvertBinToHex(num));
            Console.WriteLine(Converter.ConvertDecToBin(222));
        }
    }
}