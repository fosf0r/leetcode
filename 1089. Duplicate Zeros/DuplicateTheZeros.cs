// Test case:

int[] testcase = new int[] { 1,0,2,3,0,4,5,0 };
DuplicateZeros(testcase); // should return: 1,0,0,2,3,0,0,4


int[] testcase2 = new int[] { 0,1,7,6,0,2,0,7 };
DuplicateZeros(testcase2); // should return: 0,0,1,7,6,0,0,2

foreach (var item in testcase) {
    Console.WriteLine(item);
}
Console.WriteLine("");

foreach (var item in testcase2) {
    Console.WriteLine(item);
}
Console.WriteLine("");

// Admittedly naive implementation:
void DuplicateZeros(int[] arr) {
    int insertscount = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == 0) {
            insertscount++;
        }
    }

    int[] finalarray = new int[arr.Length + insertscount];

    insertscount = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == 0) {
            insertscount++;
        } else {
            finalarray[i + insertscount] = arr[i];
        }
    }
    Array.Copy(finalarray, arr, arr.Length);
}

// TODO: Rewrite the above while going from right-to-left, instead of going left to right using a bigger array just to end up truncating it to arr.Length.

