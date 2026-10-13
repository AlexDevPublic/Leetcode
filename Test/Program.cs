
var s = Solution.TwoSum([-3, 3, 4, 90], 0);
var a = 1;

public class Solution
{
    private const int _maxNumbersLength = 3 * 100000;
    public static int[] TwoSum(int[] numbers, int target)
    {
        if (numbers.Length <= 1)
            throw new ArgumentException("Array must be more than 2 elements");

        if (numbers.Length > _maxNumbersLength)
            throw new ArgumentException($"The array has more than {_maxNumbersLength} elements");
        var leftIndex = 0;
        var rightIndex = numbers.Length - 1;
        var leftValue = numbers[leftIndex];
        var rightValue = numbers[rightIndex];

        while (target != leftValue + rightValue)
        {
            if (rightValue > target && leftValue >= 0)
            {
                rightIndex--;
                rightValue = numbers[rightIndex];
                continue;
            }
            if (leftValue + rightValue < target)
            {
                leftIndex++;
                leftValue = numbers[leftIndex];
                continue;
            }

            rightIndex--;
            rightValue = numbers[rightIndex];
        }
        
        return new[] { leftIndex+1, rightIndex+1 };
    }
}