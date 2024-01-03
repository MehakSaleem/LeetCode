public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sumFound = new int[2];
        for(int i=0;i<= (nums.Length)-1;i++)
        {
            for(int j=i+1;j<=(nums.Length)-1;j++){
                 if((nums[i] + nums[j] == target))
                 {
                    sumFound[0] = i;
                    sumFound[1] = j;
                }
            }
        } 
        return sumFound;       
    }
}