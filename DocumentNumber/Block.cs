namespace DocumentNumber;

internal class Block {
    private string _value;
    private BlockType _type;

    public string Value => _value;
    public BlockType Type => _type;

    public Block(string value, BlockType type) {
        _value = value;
        _type = type;
    }
}
