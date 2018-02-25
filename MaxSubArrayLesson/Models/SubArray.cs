namespace MaxSubArrayLesson.Models
{
    public class SubArray
    {
        public int Low { get; set; }

        public int High { get; set; }

        public int Sum { get; set; }

        public SubArray(int low, int high, int sum)
        {
            Low = low;
            High = high;
            Sum = sum;
        }
    }
}
