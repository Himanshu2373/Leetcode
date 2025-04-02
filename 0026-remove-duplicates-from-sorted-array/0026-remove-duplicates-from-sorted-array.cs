public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int size=0;
        for(int j=1; j<nums.Length; j++)
        {
            if(nums[size]!=nums[j])
            {
                size++;
                nums[size]=nums[j];
            }
        }
        return size+1;
    }
}