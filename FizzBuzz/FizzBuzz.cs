List<string> FizzBuzz(int n) {
    List<string> answer = new();
    for (int i = 1; i - 1 < n; i++) {
        System.Text.StringBuilder fb = new();
        if (i % 3 == 0) {
            fb.Append("Fizz");
        }
        if (i % 5 == 0) {
            fb.Append("Buzz");
        }
        if (fb.Length > 0) {
            answer.Add(fb.ToString());
        } else {
            answer.Add(i.ToString());
        }
    }
    return answer;
}

// Test cases
Console.WriteLine(string.Join(",", FizzBuzz(3)));
Console.WriteLine(string.Join(",", FizzBuzz(5)));
Console.WriteLine(string.Join(",", FizzBuzz(15)));
