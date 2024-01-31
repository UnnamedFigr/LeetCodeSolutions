namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Easy
            return;
        }

        static Dictionary<int, int> lst = new Dictionary<int, int>();
        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int secNum = target - nums[i];
                if (lst.ContainsKey(secNum))
                {
                    return new int[] { i, lst[secNum] };
                }
                if (!lst.ContainsKey(nums[i])) lst.Add(nums[i], i);
            }
            return new int[] { 0 };
        }
    }
}