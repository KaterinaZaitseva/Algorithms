namespace NumericalRepresentation {
    internal class Program {
        public static void Main(string[] args) { 

            byte[] arr = { 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1};
            BinaryRepresentation num = new BinaryRepresentation(arr);
            Console.WriteLine(num.ToString());                   // 111001010111
            Console.WriteLine(num.ToString(30));                 // 000000000000000000111001010111
            Console.WriteLine(Converter.ConvertBinToDec(num));   // 3671
            Console.WriteLine(Converter.ConvertBinToOct(num));   // 7127
            Console.WriteLine(Converter.ConvertBinToHex(num));   // E57
            Console.WriteLine(Converter.ConvertDecToBin(335));   // 101001111
        }
    }
}