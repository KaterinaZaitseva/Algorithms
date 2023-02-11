using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalRepresentation
{
    internal static class Converter
    {
        public static long ConvertBinToDec(BinaryRepresentation binNumber)
        {
            int decNumber = 0;

            for (int i = binNumber.Length - 1; i >= 0; i--)
                decNumber += binNumber.GetBit(binNumber.Length - 1 -i) << i;

            return decNumber;
        }

        public static BinaryRepresentation ConvertDecToBin(int decNumber)
        {
            BinaryRepresentation binNumber = new BinaryRepresentation(decNumber);
            int i = 0;

            while(decNumber > 0)
            {
                if((decNumber & 1) == 1)
                    binNumber.EnableBit(i);
                else binNumber.DisableBit(i);
                decNumber >>= 1;
                i++;
            }

            binNumber.CutBits(i);
            binNumber.ReverseBits();

            return binNumber;
        }

        public static string ConvertBinToOct(BinaryRepresentation binNumber)
        {
            string octNumber = "";
            int currentDigit = 0;

            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int bitIndex = binNumber.Length - i - 1;

                currentDigit += binNumber.GetBit(i) == 1 
                    ? 1 << (bitIndex % 3) 
                    : 0;

                if(bitIndex % 3 == 2)
                {
                    octNumber += currentDigit.ToString();
                    currentDigit = 0;
                }
            }

            if(binNumber.Length % 3 != 0)
                octNumber += currentDigit.ToString();

            return ReverseString(octNumber);
        }

        public static string ConvertBinToHex(BinaryRepresentation binaryNumber)
        {
            string hexNumber = "";
            int currentDigit = 0;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                int bitIndex = binaryNumber.Length - i - 1;

                currentDigit += binaryNumber.GetBit(i) == 1
                   ? 1 << (bitIndex % 4)
                   : 0;

                if (bitIndex % 4 == 3)
                {
                    if (currentDigit >= 10)
                    {
                        hexNumber += (char)(currentDigit - 10 + 'A');
                    }
                    else hexNumber += currentDigit.ToString();
                    currentDigit = 0;
                }
            }

            if (binaryNumber.Length % 4 != 0)
                hexNumber += currentDigit.ToString();

            return ReverseString(hexNumber);
        }

        public static string ReverseString(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string reversedString = new string(c);
            return reversedString;
        }
    }
}
