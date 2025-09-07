

namespace תרגיל_יחידה
{
    public static class q2
    {
        public static bool IsSortedPalindrome(string str)
        {
            if (str == "")
                return true;
            int lastChar = str[0];
            int half = (str.Length / 2) + 1;
            for (int i = 0; i < half; i++)
            {
                if ((str[i] != str[str.Length - 1 - i]) || ((int)str[i] < lastChar))
                    return false;
                lastChar = (int)str[i];
            }
            return true;
        }


    }

}
