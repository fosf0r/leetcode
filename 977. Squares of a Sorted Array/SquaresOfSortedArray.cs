// Test case:
// Input: nums = [-4, -1, 0, 3, 10]
// Output: [0,1,9,16,100]

int[] SortedSquares(int[] nums) {
    // Square them all in place:
    for (int i = 0; i < nums.Length; i++) {
        nums[i] *= nums[i];
    }
    // Naive in-place sort:
    Array.Sort(nums);
    return nums;
}
