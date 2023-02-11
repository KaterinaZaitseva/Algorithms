namespace NumericalRepresentation
{
    internal class BinaryRepresentation
    {
        private byte[] _bits;
        private int _length;
        
        public int Length { get { return _length; } }

        public BinaryRepresentation(int number)
        {
            if (number >> 32 != 0)
            {
                _bits = new byte[64];
                _length = 64;
            }
            else
            {
                _bits = new byte[32];
                _length = 32;
            }
        }

        public BinaryRepresentation(byte[] bits)
        {
            _bits = bits;
            _length = bits.Length;
        }

        public byte GetBit(int index)
        {
            return _bits[index];
        }

        public void EnableBit(int index)
        {
            _bits[index] = 1;
        }
        public void DisableBit(int index)
        {
            _bits[index] = 0;
        }

        public void ReverseBits()
        {
            Array.Reverse(_bits);
        }

        public void InverseBit(int index)
        {
            _bits[index] = (byte)~_bits[index];
        }

        public void CutBits(int length)
        {
           byte[] temp = new byte[length];
           Array.Copy(_bits, 0, temp, 0, length);
            _bits = temp;
            _length = temp.Length;
        }

        public override string ToString()
        {
            string result = "";

            if (_bits != null)
                for (int i = 0; i < _length; i++)
                    result += _bits[i].ToString();

            return result;
        }

        public string ToString(int resultLength)
        {
            string result = "";
            if (_bits != null)
            {
                if (resultLength > _length)
                {
                    for (int i = 0; i < resultLength - _length; i++)
                        result += "0";

                    for (int i = 0; i < _length; i++)
                        result += _bits[i].ToString();
                }
                else
                {
                    for (int i = 0; i < resultLength; i++)
                        result += _bits[i];
                }
            }
            return result;
        }
    }
}
