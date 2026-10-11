Console.WriteLine(Solution.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));

public static class Solution
{
    private const int HeightMaxLength = 1000000;
    private const int HeightMinLength = 2;
    private const int MinValue = 0;
    private const int MaxValue = 10000;

    public static int MaxArea(int[] height)
    {
        if (height.Length < HeightMinLength)
        {
            throw new ArgumentException($"The amount of height is less than {HeightMinLength}");
        }

        if (height.Length > HeightMaxLength)
        {
            throw new ArgumentException($"The amount of height is higher than {HeightMaxLength}");
        }

        int leftIndex = 0, rightIndex = height.Length - 1, maxArea = 0;

        while (leftIndex < rightIndex)
        {
            var h = Math.Min(height[leftIndex], height[rightIndex]);

            var w = rightIndex - leftIndex;

            var newArea = h * w;

            if (newArea > maxArea)
            {
                maxArea = newArea;
            }

            if (height[leftIndex] < height[rightIndex])
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return maxArea;
    }
}