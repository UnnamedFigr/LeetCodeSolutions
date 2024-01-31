namespace First_Last_Position_Of_Element_In_SortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Medium
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int first = FindOccurances(nums, target, true);
            if (first == -1) return new int[] { -1, -1 };
            int second = FindOccurances(nums, target, false);
            return new int[] { first, second };
        }
        public int FindOccurances(int[] nums, int target, bool isFirst)
        {
            int index = -1;
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    index = mid;
                    if (isFirst)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return index;
        }

    }
}