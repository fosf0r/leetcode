
using System.Collections;

string ransomNote = "aa";
string magazine1 = "aba";
string magazine2 = "bbb";
Console.WriteLine(CanConstruct(ransomNote, magazine1)); // should return True
Console.WriteLine(CanConstruct(ransomNote, magazine2)); // should return False

bool CanConstruct(string ransomNote, string magazine) {
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
