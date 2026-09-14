public class Solution
{
    const int maxStringLength = 2 * 100000;

    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return false;
        }

        if (string.IsNullOrEmpty(s.Trim()) || s.Length == 1)
        {
            return true;
        }

        if (s.Length > maxStringLength)
        {
            throw new InvalidDataException($"The string max length is {maxStringLength}");
        }

        int leftIndex = 0;
        int rightIndex = s.Length - 1;

        while (leftIndex < rightIndex)
        {
            if (!char.IsLetterOrDigit(s[leftIndex]))
            {
                leftIndex++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[rightIndex]))
            {
                rightIndex--;
                continue;
            }

            if (char.ToLower(s[leftIndex]) != char.ToLower(s[rightIndex]))
            {
                return false;
            }

            leftIndex++;
            rightIndex--;
        }

        return true;
    }
}