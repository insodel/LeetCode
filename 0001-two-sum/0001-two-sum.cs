public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] newNums = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;  
                if (nums[i] + nums[j] == target)
                {
                    newNums[0] = i;
                    newNums[1] = j;
                }
                if (nums.Length == 2)
                {
                    newNums[0] = 0;
                    newNums[1] = 1;
                }                                    
            }
        }
        return newNums;
    }
}