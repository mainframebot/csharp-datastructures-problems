using MaxSubArrayLesson.Models;

namespace MaxSubArrayLesson
{
    public class MaxSubArray
    {
        public SubArray FindMaximumSubArray(int[] items, int start, int end)
        {
            if(end == start)
                return new SubArray(start, end, items[start]);

            var mid = (start + end) / 2;

            var left = FindMaximumSubArray(items, start, mid);
            var right = FindMaximumSubArray(items, mid + 1, end);
            var crossing = FindMaximumCrossingSubArray(items, start, mid, end);

            if((left.Sum >= right.Sum) && (left.Sum >= crossing.Sum))
                return left;

            if((right.Sum >= left.Sum) && (right.Sum >= crossing.Sum))
                return right;
  
            return crossing;
        }

        private SubArray FindMaximumCrossingSubArray(int[] items, int start, int mid, int end)
        {
            var leftMax = 0;
            var rightMax = 0;

            var leftSum = int.MinValue;
            var rightSum = int.MinValue;

            var sum = 0;

            for (var i = mid; i >= start; i--)
            {
                sum = sum + items[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    leftMax = i;
                }
            }

            sum = 0;

            for (var j = mid + 1; j <= end; j++)
            {
                sum = sum + items[j];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    rightMax = j;
                }
            }

            return new SubArray(leftMax, rightMax, leftSum + rightSum);
        }
    }
}
