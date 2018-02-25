using MaxSubArrayLesson;
using NUnit.Framework;

namespace MaxSubArrayTest
{
    [TestFixture]
    public class Testing
    {
        [Test]
        public void Test()
        {
            int[] items = {13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7};
            //int[] items = { -13, -3, -25, -20, -3, -16, -23, -18, -20, -7, -12, -5, -22, -15, -4, -7 };

            var result2 = new MaxSubArray3().FindMaximumSubArray(items, 0, items.Length - 1);
            var result = new MaxSubArray().FindMaximumSubArray(items, 0, items.Length - 1);
        }
    }
}
