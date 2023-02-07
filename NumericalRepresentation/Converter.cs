using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalRepresentation
{
    internal class Converter
    {
        public static string ConvertBinToDec(BinaryRepresentation num)
        {
            int result = 0;
            for (int i = num.GetLength() - 1; i >= 0; i--)
                result += num.GetBit(num.GetLength() - 1 - i) * (int)Math.Pow(2, i);
            return result.ToString();
        }

        public static string ConvertDecToBin(int num)
        {
            if (num != 0)
            {
                string str = "";
                while (num != 0)
                {
                    str += num % 2;
                    num /= 2;
                }
                char[] c = str.ToCharArray();
                Array.Reverse(c);
                string result = new string(c);
                return result;
            }
            return "0";
        }

        public static string ConvertBinToOct(BinaryRepresentation num)
        {
            int dec = Int32.Parse(ConvertBinToDec(num));
            if (dec != 0)
            {
                string str = "";

                while (dec != 0)
                {
                    str += dec % 8;
                    dec /= 8;
                }
                char[] c = str.ToCharArray();
                Array.Reverse(c);
                string result = new string(c);
                return result;
            }
            return "0";
        }

        public static string ConvertBinToHex(BinaryRepresentation num)
        {
            int dec = Int32.Parse(ConvertBinToDec(num));
            if (dec != 0)
            {
                string str = "";
                while (dec != 0)
                {
                    switch (dec % 16)
                    {
                        case 10:
                            str += "A";
                            break;
                        case 11:
                            str += "B";
                            break;
                        case 12:
                            str += "C";
                            break;
                        case 13:
                            str += "D";
                            break;
                        case 14:
                            str += "E";
                            break;
                        case 15:
                            str += "F";
                            break;
                        default:
                            str += dec % 16;
                            break;
                    }
                    dec /= 16;
                }
                char[] c = str.ToCharArray();
                Array.Reverse(c);
                string result = new string(c);
                return result;
            }
            return "0";
        }
    }
}
