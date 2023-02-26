
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections;

[MemoryDiagnoser]
public class Program {

    public IEnumerable<string> testCases = new string[] { "aa", "aba" };;

    [Benchmark]
    [ParamsSource(nameof(testCases))]
    public static bool CanConstruct(string ransomNote, string magazine) {
        var SkipTable = new Hashtable();
        for (int i = 0; i < ransomNote.Length; i++) {
            bool foundthisone = false;
            for (int j = 0; j < magazine.Length; j++) {
                if (SkipTable.ContainsKey(j)) {
                    continue;
                } else {
                    if (ransomNote[i] == magazine[j]) {
                        foundthisone = true;
                        SkipTable.Add(j, magazine[j]);
                        break;
                    }
                }
            }
            if (!foundthisone) {
                return false;
            }
        }
        return true;
    }

    static void Main() {
        Console.WriteLine(BenchmarkRunner.Run<Program>);
    }

}
