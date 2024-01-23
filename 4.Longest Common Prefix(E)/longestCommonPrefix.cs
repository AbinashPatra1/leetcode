public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        int minLength = 99999;
        foreach (string s in strs)
        {
            if (s.Length < minLength)
                minLength = s.Length;
        }

        string prefix = "";
        for (int i = 0; i < minLength; i++)
        {
            char letter = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
            {
                if (letter != strs[j][i])
                {
                    return prefix;
                }
            }
            prefix = prefix + strs[0][i];
        }
        return prefix;
    }
}