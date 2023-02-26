
// Test case:
int[] mynums = new int[] { 1, 1, 0, 1, 1, 1, 1, 2, 3, 2, 3, 1, 1, 1 };
Console.WriteLine(FindMaxConsecutiveOnes(mynums));

int FindMaxConsecutiveOnes(int[] nums) {
    int onecount = 0;
    int bestrun = 0;
    for (int i = 0; i < nums.Length; i++) {
        if (nums[i] == 1) {
            onecount++;
            if (onecount > bestrun) {
                bestrun = onecount;
            }
        } else {
            onecount = 0;
        }
    }
    return bestrun;
}

