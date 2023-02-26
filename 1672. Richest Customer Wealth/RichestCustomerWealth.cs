// Test case:
int[][] accounts = new int[][] { new int[] { 1, 2, 3 } , new int[] { 3, 1, 1 } };

Console.WriteLine(MaximumWealth(accounts)); // should return 6

int MaximumWealth(int[][] accounts) {
    int wealth;
    int richest = 0;
    for (int i = 0; i < accounts.Length; i++) {
        wealth = 0;
        for (int j = 0; j < accounts[i].Length; j++) {
            wealth += accounts[i][j];
            if (wealth > richest) {
                richest = wealth;
            }
        }
    }
    return richest;
}
