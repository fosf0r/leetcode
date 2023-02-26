
// how I did it, naive mode:
int[] TwoSum(int[] nums, int target) {
    int[] answer = new int[2];
    for (int i = 0; i < nums.Length; i++) {
        for (int j = i + 1; j < nums.Length; j++) {
            if (nums[i] + nums[j] == target) {
                answer[0] = i;
                answer[1] = j;
                return answer;
            }
        }
    }
    return answer;
}

// How I should have done it:
int[] TwoSum2(int[] nums, int target) {
    int left = 0, right = nums.Length - 1;
    while ((nums[left] + nums[right]) != target)
        if ((nums[left] + nums[right]) > target) {
            // optional enhancement: duplicate number check
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

// Test case
// int[] mynums = {-1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
int[] mynums = {3,2,4};
int target = 6;
Console.WriteLine(string.Join(",", TwoSum2(mynums, target).ToList()));
