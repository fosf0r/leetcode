
int NumberOfSteps(int num) {
    int steps = 0;
    while (num != 0) {
        if (num % 2 == 0) {
            num >>= 1;
        } else {
            num -= 1;
        }
        steps++;
    }
    return steps;
}

// Test cases
Console.WriteLine(NumberOfSteps(14)); // 6
Console.WriteLine(NumberOfSteps(8)); // 4 
Console.WriteLine(NumberOfSteps(123)); // 12
