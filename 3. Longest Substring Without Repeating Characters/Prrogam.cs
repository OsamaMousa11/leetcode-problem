namespace _3._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {

       
        public  int LengthOfLongestSubstring(string s)
        {

            var uniquechar = s.ToLower().Substring(0, s.Length).Distinct();
            int counter = 0;
            foreach(var x in uniquechar)
            {
                counter++;
            }
            return counter;
        }
    }
}
