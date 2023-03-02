// test case:

int[] nums1a = new int[] { 1, 3 };
int[] nums2a = new int[] { 2 };
Console.WriteLine(FindMedianSortedArrays(nums1a, nums2a)); // should return 2.0

// test case 2:
int[] nums1b = new int[] { 1, 2 };
int[] nums2b = new int[] { 3, 4 };
Console.WriteLine(FindMedianSortedArrays(nums1b, nums2b)); // should return 2.5

// this one's easier to read but got a lower score at leetcode:
/*double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    double answer = 0;
    int[] merged = nums1.Concat(nums2).OrderBy(x => x).ToArray();

    if (merged.Length % 2 == 0)
    {
        int left = (merged.Length - 1) / 2;
        answer = (double)(merged[left] + merged[left + 1]) / 2;
    } else
    {
        answer = merged[merged.Length - 1 - (merged.Length / 2)];
    }

    return answer;
}
*/

double FindMedianSortedArrays(int[] nums1, int[] nums2) {
    double answer = 0;
    List<int> merged = new();

    for (int i = 0; i < nums1.Length; i++) {
        merged.Add(nums1[i]);
    }
    for (int i = 0; i < nums2.Length; i++) {
        merged.Add(nums2[i]);
    }

    merged.Sort(); // naive sort in place

    if (merged.Count % 2 == 0) {
        int left = (merged.Count - 1) / 2;
        answer = (double)(merged[left] + merged[left + 1]) / 2;
    } else {
        answer = merged[merged.Count - 1 - (merged.Count / 2)];
    }

    return answer;
}