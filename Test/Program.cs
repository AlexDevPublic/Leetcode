
var s = "\t";

Console.WriteLine(Solution.LengthOfLongestSubstring(s));

public static class Solution
{
    private const int maxStringLength = 100000;
    public static int LengthOfLongestSubstring (string s)
    {
        if (s.Length > maxStringLength)
        {
            throw new ArgumentException($"Max length of string is {maxStringLength}");
        }
        var chars = new HashSet<char>();

        int maxSubstringLength = 0, leftIndex = 0;

        for (int rightIndex = 0; rightIndex < s.Length;  rightIndex++)
        {
            var ch = s[rightIndex];

            var a = char.IsSymbol(ch);

            if (!IsAllowedCharacter(ch))
            {
                throw new InvalidDataException("String must consists of English letters, digits, symbols and spaces");
            }

            while (chars.Contains(ch))
            {
                chars.Remove(s[leftIndex]);
                leftIndex++;
            }

            chars.Add(ch);

            maxSubstringLength = Math.Max(maxSubstringLength, rightIndex - leftIndex + 1);
        }

        return maxSubstringLength;
    }

    private static bool IsAllowedCharacter(char ch) =>
        char.IsLetter(ch) && ch <= 127 ||
        char.IsDigit(ch) ||
        char.IsSymbol(ch) ||
        char.IsPunctuation(ch) ||
        ch == ' ';
}