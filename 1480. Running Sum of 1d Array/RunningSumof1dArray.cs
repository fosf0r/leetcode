
// Test case:
int[] mynums = {1, 2, 3, 4};
Console.WriteLine(string.Join(",", RunningSum(mynums).ToList()));

int[] RunningSum(int[] nums) {
    for (int i = 1; i < nums.Length; i++) {
        nums[i] += nums[i - 1];
    }
    return nums;
}
