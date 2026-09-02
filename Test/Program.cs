Console.WriteLine("Hello, World!");


public class Solution
{
    private const int _MaxLettersCount = 100000;
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if (string.IsNullOrEmpty(ransomNote) || string.IsNullOrEmpty(magazine))
        {
            return false;
        }
        ValidateMaxLettersCount(ransomNote);
        ValidateMaxLettersCount(magazine);

        var lettersCount = Countletters(magazine);

        foreach (var letter in ransomNote)
        {
            if (!lettersCount.TryGetValue(letter, out var count) || count == 0)
            {
                return false;
            }

            lettersCount[letter] -= 1;
        }

        return true;

    }
    private static void ValidateMaxLettersCount(string str)
    {
        if (str.Length >= _MaxLettersCount)
        {
            throw new ArgumentException("Invalid max letters count");
        }
    }

    private static Dictionary<char, int> Countletters(string str)
    {
        var lettersCount = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (!lettersCount.ContainsKey(c))
            {
                lettersCount.Add(c, str.Count(letter => letter == c));
            }
        }

        return lettersCount;
    }
}