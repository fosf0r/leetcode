int[] mynums = new int[] { 12,345,2,6,7896 };

Console.WriteLine(FindNumbers(mynums)); // should be 2

int FindNumbers(int[] nums) {
    int counter = 0;
    for (int i = 0; i < nums.Length; i++) {
        if (nums[i].ToString().Length % 2 == 0) {
            counter++;
        }
    }
    return counter;
}