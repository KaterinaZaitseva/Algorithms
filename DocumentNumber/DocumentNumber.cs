using System.Text;

namespace DocumentNumber;

internal class DocumentNumber {
    private List<Block> _blocks;
    public List<Block> Blocks { get { return _blocks; } set { _blocks = value; } } 

    public DocumentNumber(string documentNumber) => _blocks = Split(documentNumber);

    public List<Block> Split(string value) {
        List<Block> result = new List<Block>();
        BlockType blockType;
        int checkSymbol = 0;
        foreach(string block in value.Split('-')) {
            foreach(char symbol in block) {
                if(Char.IsLetter(symbol))
                    checkSymbol++;
            }
            if(checkSymbol > 0)
                blockType = checkSymbol == block.Length ? BlockType.OnlyLetters : BlockType.Mixed;
            else blockType = BlockType.OnlyDigits;
            checkSymbol = 0;
            result.Add(new Block(block, blockType));
        }
        return result;
    }

    public string GetOnlyDigitalBlocks() {
        string result = "";
        int i = 1;
        foreach(Block block in _blocks) {
            if(block.Type == BlockType.OnlyDigits) {
                result += block.Value + '-';
            }
        }
        return result.Remove(result.Length - 1);
    }

    public string GetWithoutOnlyLettersBlocks() {
        string result = "";
        int i = 1;
        foreach(Block block in _blocks) {
            if(block.Value.Length == 3 && block.Type == BlockType.OnlyLetters)
                result +=  "***";
            else result += block.Value;
            if(i++ != _blocks.Count)
                result += '-';
        }
        return result;
    }

    public string GetOnlyLetters() {
        string result = "";
        int i = 1;
        foreach(Block block in _blocks) {
            if(block.Type == BlockType.OnlyLetters)
                result += block.Value;
            else if(block.Type == BlockType.Mixed) {
                foreach(char symbol in block.Value) {
                    if(Char.IsLetter(symbol))
                        result += symbol;
                }
            }
            else { i++; continue; }
            if(i++ != _blocks.Count)
                result += '/';
        }
        return result.ToLower();
    }

    public StringBuilder GetOnlyLettersUsingStringBuilder() {
        StringBuilder result = new StringBuilder();
        int i = 1;
        foreach(Block block in _blocks) {
            if(block.Type == BlockType.OnlyLetters)
                result.Append(block.Value.ToUpper());
            else if(block.Type == BlockType.Mixed) {
                foreach(char symbol in block.Value) {
                    if(Char.IsLetter(symbol))
                        result.Append(symbol.ToString().ToUpper());
                }
            }
            else { i++; continue; }
            if(i++ != _blocks.Count)
                result.Append('/');
        }
        return result;
    }

    public bool ContainsABC() {
        if(this.ToString().Contains("abc", StringComparison.OrdinalIgnoreCase))
            return true;
        else return false;
    }

    public bool FirstSymbols() {
        if(this.ToString().IndexOf("555") == 0)
            return true;
        else return false;
    }

    public bool EndSymbols() {
        string temp = this.ToString();
        if(temp.IndexOf("1a2b") == temp.Length - 4)
            return true; 
        else return false;
    }

    public override string? ToString() {
        string result = null;
        foreach(Block block in _blocks)
            result += block.Value;
        return result; 
    }
}
