public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int len = nums.Length;
        if(len == 1)
        {
            return len;
        }
        int i = 0;
        int j = 1;
        while(j < len)
        {
            if(nums[j] > nums[i])
            {
                ++i;
                nums[i] = nums[j];
            }
            else
            {
                ++j;
            }
        }
        return i+1;
    }
}