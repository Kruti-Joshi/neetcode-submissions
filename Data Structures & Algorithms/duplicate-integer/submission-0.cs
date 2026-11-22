public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach(int n in nums){
            bool added = seen.Add(n);
            if(!added){
                return true;
            }
        }

        return false;
    }
}