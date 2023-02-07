namespace NumericalRepresentation
{
    internal class BinaryRepresentation
    {
        int[] _bits;

        public BinaryRepresentation(int[] bits)
        {
            _bits = bits;
        }

        public int GetBit(int index)
        {
            return _bits[index];
        }

        public void SetBit(int index, int value)
        {
            _bits[index] = value;
        }

        public int GetLength()
        {
            return _bits.Length;
        }
    }
}
