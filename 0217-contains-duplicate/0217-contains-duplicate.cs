public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            int element = nums[i];
            for (int j = i +1; j < nums.Length; j++)
            {
                if (nums[j] == element)
                    return true;
            }
        }
        return false;
       
    }
}