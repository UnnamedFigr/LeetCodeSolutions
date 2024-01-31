namespace Remove_Duplicates_From_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Easy
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int prev = nums[i - 1];
                if (nums[i] != prev)
                {
                    nums[count++] = nums[i];
                }

            }
            return count;
        }
    }
}