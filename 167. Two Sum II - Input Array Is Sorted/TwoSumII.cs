// Test case:
int[] mynums = new int[] { 2, 7, 11, 15 };
int target = 9;
foreach (var item in TwoSum2(mynums, target)) {
    Console.WriteLine(item); // test case should return: 1, then 2
}


int[] TwoSum2(int[] nums, int target) {
    int left = 0, right = nums.Length - 1;
    while ((nums[left] + nums[right]) != target)
        if ((nums[left] + nums[right]) > target) {
            if (nums[right - 1] == nums[right]) {
                for (int i = right; right > left; i--) {
                    if (nums[i] != nums[i - 1]) {
                        right = i;
                        break;
                    }
                }
            } else {
                right--;
            }
        } else {
            left++;
        }
    return new int[] { left + 1, right + 1 };
}
