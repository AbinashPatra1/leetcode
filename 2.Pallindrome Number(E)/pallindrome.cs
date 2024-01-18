public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        else
        {
            char[] arr = x.ToString().ToCharArray();
            for(int i = 0; i< arr.Length/2; i++)
            {
                if(arr[i] != arr[arr.Length -i-1])
                    return false;
            }
            return true;
        }
        return true;
    }
}

//////WITHOUT CONVERTING THE NUMBER INTO A STRING/ CHAR ARRAY

public class Solution {
    public bool IsPalindrome(int x) {
        int dup = x;
        int reverse = 0;
        while(x > 0)
        {
            int LD = x % 10;
            reverse = reverse * 10 + LD; 
            x = x/10;
        }
        if(dup != reverse || dup < 0)
            return false;
        else
            return true;
    }
}