using MaxSubArrayLesson.Models;

namespace MaxSubArrayLesson
{
    public class MaxSubArray3
    {
        public SubArray FindMaximumSubArray(int[] items, int start, int end)
        {
            var count = items.Length;

            var highestSum = int.MinValue;
            var highestStart = 0;
            var highestEnd = 0;

            for (var i = 0; i <= count; i++)
            {
                var sum = 0;

                for (var j = i; j <= count - 1; j++)
                {
                    sum = sum + items[j];

                    if (sum > highestSum)
                    {
                        highestSum = sum;
                        highestStart = i;
                        highestEnd = j;
                    }
                }
            }

            return new SubArray(highestStart, highestEnd, highestSum);
        }
    }
}
