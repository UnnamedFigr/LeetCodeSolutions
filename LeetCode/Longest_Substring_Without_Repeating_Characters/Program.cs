namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Medium
            return;
        }

        static Dictionary<char, int> arr = new Dictionary<char, int>();
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0, left = 0, right = 0;
            for (right = 0; right < s.Length; right++)
            {
                char ch = s[right];
                if (arr.ContainsKey(ch))
                {
                    left = left >= (arr[ch] + 1) ? left : arr[ch] + 1;
                }
                arr[ch] = right;
                max = max >= right - left + 1 ? max : right - left + 1;
            }
            return max;
        }
        
    }
}