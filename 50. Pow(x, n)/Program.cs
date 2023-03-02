/*Console.WriteLine(MyPow(2.00000f, 10));
Console.WriteLine(MyPow(2.10000f, 3));
Console.WriteLine(MyPow(2.00000f, -2));
Console.WriteLine(MyPow(1.00000f, 2));
Console.WriteLine(MyPow(1.00000f, 0));
*/

Console.WriteLine(MyPow(8.95371f, -1));

double MyPow(double x, int n) {
    int count;
    if (n >= 0) {
        count = n;
    } else {
        count = n * -1;
    }
    if (n == 0) {
        return 1;
    }
    if (x == 1) {
        return 1;
    }
    if (x == -1 && n > 0) {
        return -1;
    }
    if (x == -1 && n < 0) {
        return 1;
    }
    if (n == 1) {
        return x;
    }
    if (count > 2147483646) {
        return 0;
    }
    double mine = x;
    for (int i = 0; i < count - 1; i++) {
        x = x * mine;
    }
    if (n < 0) {
        return 1 / x;
    } else {
        return x;
    }
}
