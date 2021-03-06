namespace Elements_of_Programming_Interviews.Strings.PalindromiCity
{
    public class Solution
    {
        public static bool IsPalindrome(string s)
        {
            // i moves forward, and j moves backward.
            int i = 0;
            int j = s.Length-1;

            while(i < j)
            {
                // i and j both skip non-alphanumeric characters.
                while(!char.IsLetterOrDigit(s[i]) && i < j)
                {
                    i++;
                }
                while(!char.IsLetterOrDigit(s[j]) && i < j)
                {
                    j--;
                }
                if(char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}