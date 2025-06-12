namespace _3._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {

       
        public  int LengthOfLongestSubstring(string s)
        {

            HashSet<char> charSet = new HashSet<char>();
            int left = 0;
            int MaxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }
                charSet.Add(s[right]);
                MaxLength = Math.Max(MaxLength, right - left + 1);
            }

            return MaxLength;
        }
    }
}
