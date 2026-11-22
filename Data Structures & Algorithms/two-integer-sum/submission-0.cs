public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for(int i = 0; i<nums.Length;i++){
            if(seen.TryGetValue(target-nums[i], out int compliment)){
                return [compliment, i];
            }
            else {
                seen.Add(nums[i], i);
            }
        }

        return [];
    }
}
