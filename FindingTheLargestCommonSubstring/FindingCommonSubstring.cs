using System.Collections.Generic;
using System.Globalization;

namespace FindingTheLargestCommonSubstring;
internal class FindingCommonSubstring {

    private int _p = 11;
    private int _r = 256;
    private string _firstString;
    private string _secondString;

    public FindingCommonSubstring(string firstString, string secondString)
    {
        _firstString = firstString;
        _secondString = secondString;
    }

    public string? FindMaxCommonSubstring() {
        int high = _firstString.Length > _secondString.Length ? _secondString.Length : _firstString.Length;
        int low = 0;
        int mid = 0;

        while (low < high) {
            mid = (low + high) / 2;

            if (F(mid) != null)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return F(high);
    }

    public string? F(int N) {
        List<int> hashes = new List<int>();
        int i = N;
        int hash = 0;

        string temp = _firstString[0..N];

        while (i < _firstString.Length) {
            hashes.Add(GetHash(temp));
            temp.Remove(0, 1);
            temp += _firstString[i++];
        }
        

        for (int j = 0; j < _secondString.Length - N; j++) {
            hash = GetHash(_secondString[j..(j + N - 1)].ToString());
            if (hashes.Contains(hash))
                return _secondString[j..(j + N - 1)].ToString(); //проверить случайные элементы
            else continue;
        }

        return null;
    }

    public int GetHash(string str) {
        int result = 0;

        for(int i = 0; i < str.Length; i++) 
            result = (_p * result + str[i]) % _r;

        return result;
    }

    public int GetSubstring(string str, string sub) {
        int subHash = GetHash(sub);
        int strHash = GetHash(str[0..sub.Length]);
        int maxP = 1;
        int count = 0;
        for (int i = 1; i <= sub.Length; i++)
            maxP = (maxP * _p) % _r;

        for (int i = 0; i < str.Length - sub.Length; i++) {
            if (subHash == strHash)
                count++;
            //strHash = ((strHash - str[i] *maxP) * p + str[i + sub.Length]) % r;
            strHash = (_p * strHash - maxP * GetHash(str[i].ToString()) + GetHash(str[i + sub.Length].ToString())) % _r;
        }

        return count;
    }

}
