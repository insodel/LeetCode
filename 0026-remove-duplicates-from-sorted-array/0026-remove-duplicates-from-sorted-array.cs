public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0; 
        if (nums.Count() == 0)
            return k;
        else
        {
            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }
            return j + 1;
        }
    }
}