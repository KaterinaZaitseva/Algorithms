using System.Collections.Generic;
using System.Globalization;

namespace FindingTheLargestCommonSubstring;
internal class FindingCommonSubstring {

    private long _primeNumber = 1111111;
    private long _restrictor = 4294967296;
    private string _firstString;
    private string _secondString;

    public FindingCommonSubstring(string firstString, string secondString) {
        _firstString = firstString;
        _secondString = secondString;
    }

    public string? FindMaxCommonSubstring(bool needCheck) {
        int high = _firstString.Length > _secondString.Length ? _secondString.Length: _firstString.Length;
        int low = 0;
        int mid = 0;

        while (low <= high) {
            mid = (low + high) / 2;

            if (CheckSubstring(mid, needCheck) != null)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return CheckSubstring(high, needCheck);
    }

    private string? CheckSubstring(int substringSize, bool needCheck) {
        List<long> hashes = new List<long>();
        long hash;
        string currentSubstring;
        int indexSubstring;

        for (int i = 0; i <= _firstString.Length - substringSize; i++)
            hashes.Add(GetHash(_firstString[i..(i + substringSize)]));

        for (int j = 0; j <= _secondString.Length - substringSize; j++) {
            currentSubstring = _secondString[j..(j + substringSize)];
            hash = GetHash(currentSubstring);
            indexSubstring = hashes.IndexOf(hash);
            if (indexSubstring != -1) {
                if (needCheck) {
                    if (currentSubstring == _firstString[indexSubstring..(indexSubstring + substringSize)])
                        return currentSubstring;
                }
                else return currentSubstring;
            }
        }

        return null;
    }

    private long GetHash(string str) {
        long result = 0;

        for(int i = 0; i < str.Length; i++) 
            result = (_primeNumber * result + str[i]) % _restrictor;

        return result;
    }

    public int GetCommonSubstringCount(string str, string sub) {
        long subHash = GetHash(sub);
        long strHash = GetHash(str[0..sub.Length]);
        long maxP = 1;
        int count = 0;
        for (int i = 1; i <= sub.Length; i++)
            maxP = (maxP * _primeNumber) % _restrictor;

        for (int i = 0; i < str.Length - sub.Length; i++) {
            if (subHash == strHash)
                count++;
            //strHash = ((strHash - str[i] *maxP) * p + str[i + sub.Length]) % r;
            strHash = (_primeNumber * strHash - maxP * GetHash(str[i].ToString()) + GetHash(str[i + sub.Length].ToString())) % _restrictor;
        }

        return count;
    }

}
