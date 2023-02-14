using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalRepresentation {
    internal static class Converter {

        public static long ConvertBinToDec(BinaryRepresentation binNumber) {
            int decNumber = 0;

            for (int i = 0; i < binNumber.Length; i++)
                decNumber += binNumber.GetBit(i) << i;

            return decNumber;
        }

        public static BinaryRepresentation ConvertDecToBin(int decNumber) {
            BinaryRepresentation binNumber = new BinaryRepresentation(decNumber);
            int i = 0;

            while(decNumber > 0) {
                if((decNumber & 1) == 1)
                    binNumber.EnableBit(i);
                else binNumber.DisableBit(i);
                decNumber >>= 1;
                i++;
            }

            binNumber.CutBits(i);

            return binNumber;
        }

        public static string ConvertBinToOct(BinaryRepresentation binNumber) {
            string octNumber = "";
            int currentDigit = 0;

            for (int i = 0; i < binNumber.Length; i++) {
                currentDigit += binNumber.GetBit(i) == 1 
                    ? 1 << (i % 3) 
                    : 0;

                if(i % 3 == 2) {
                    octNumber += currentDigit.ToString();
                    currentDigit = 0;
                }
            }

            if(binNumber.Length % 3 != 0)
                octNumber += currentDigit.ToString();

            return ReverseString(octNumber);
        }

        public static string ConvertBinToHex(BinaryRepresentation binNumber) {
            string hexNumber = "";
            int currentDigit = 0;

            for (int i = 0; i < binNumber.Length; i++) {
                currentDigit += binNumber.GetBit(i) == 1
                   ? 1 << (i % 4)
                   : 0;

                if (i % 4 == 3)  {
                    if (currentDigit >= 10)
                        hexNumber += (char)(currentDigit - 10 + 'A');
                    else hexNumber += currentDigit.ToString();

                    currentDigit = 0;
                }
            }

            if (binNumber.Length % 4 != 0)
                hexNumber += currentDigit.ToString();

            return ReverseString(hexNumber);
        }

        public static string ReverseString(string str) {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string reversedString = new string(c);
            return reversedString;
        }

    }
}
