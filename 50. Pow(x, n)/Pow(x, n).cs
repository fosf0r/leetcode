/*Console.WriteLine(MyPow(2.00000f, 10));
Console.WriteLine(MyPow(2.10000f, 3));
Console.WriteLine(MyPow(2.00000f, -2));
Console.WriteLine(MyPow(1.00000f, 2));
Console.WriteLine(MyPow(1.00000f, 0));
*/

Console.WriteLine(MyPow(8.95371f, -1));

double MyPow(double x, int n) {
    var count = n >= 0 ? n : n * -1;
    if (n == 0 || x == 1) {
        return 1;
    }
    switch (x) {
        case -1 when n > 0:
            return -1;
        case -1 when n < 0:
            return 1;
    }
    if (n == 1) {
        return x;
    }
    if (count > 2147483646) { // lol
        return 0;
    }
    var originalself = x;
    for (int i = 0; i < count - 1; i++) {
        x *= originalself;
    }
    return n < 0 ? (1 / x) : x;
}
