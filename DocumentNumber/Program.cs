namespace DocumentNumber;

internal class Program {
    public static void Main(string[] args) {
        DocumentNumber documentNumber = new("5555-ppp-5678-nbh-2u9o");
        Console.WriteLine(documentNumber.GetOnlyDigitalBlocks());
        Console.WriteLine(documentNumber.GetWithoutOnlyLettersBlocks());
        Console.WriteLine(documentNumber.GetOnlyLettersUsingStringBuilder());
        Console.WriteLine(documentNumber.GetOnlyLetters());
        Console.WriteLine(documentNumber.ContainsABC());
    }
}