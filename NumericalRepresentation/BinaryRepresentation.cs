namespace NumericalRepresentation {
    internal class BinaryRepresentation {

        private byte[] _bits;
        private int _length;
        public int Length => _length;

        public BinaryRepresentation(int number) {
            _bits = number >> 32 != 0 ? AllocateMemory(64) : AllocateMemory(32);
        }

        private byte[] AllocateMemory(int count) {
            _length = count;
            return new byte[count];
        }

        public BinaryRepresentation(byte[] bits) {
            _bits = bits;
            _length = bits.Length;
        }

        public byte GetBit(int index) {
            return _bits[index];
        }

        public void EnableBit(int index) {
            _bits[index] = 1;
        }
        public void DisableBit(int index) {
            _bits[index] = 0;
        }

        public void ReverseBits() {
            Array.Reverse(_bits);
        }

        public void InverseBit(int index) {
            _bits[index] = (byte)~_bits[index];
        }

        public void CutBits(int length) {
           byte[] temp = new byte[length];
           Array.Copy(_bits, 0, temp, 0, length);
            _bits = temp;
            _length = temp.Length;
        }

        public override String ToString() { 
            return ToString(_length); 
        }

        public string ToString(int resultLength) {
            String result = "";
            if (_bits != null) {
                if (resultLength > _length) {
                    result += new String('0', resultLength - _length);

                    for (int i = 0; i < _length; i++)
                        result += _bits[i].ToString();
                }
                else {
                    for (int i = 0; i < resultLength; i++)
                        result += _bits[i];
                }
            }
            return result;
        }

    }
}
