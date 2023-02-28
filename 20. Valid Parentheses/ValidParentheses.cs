// Test case:

Console.WriteLine(IsValid("()")); // should return true
Console.WriteLine(IsValid("()[]{}")); // should return true
Console.WriteLine(IsValid("(]")); // should return false
Console.WriteLine(IsValid("{{")); // should return false


bool IsValid(string s)
{
    bool curlyopen = false;
    bool curlyclosed = false;
    bool parensopen = false;
    bool parensclosed = false;
    bool squareopen = false;
    bool squareclosed = false;

    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i].ToString())
        {
            case "{":
            {
                curlyopen = true;
                break;
            }
            case "}":
            {
                curlyclosed = true;
                break;
            }
            case "[":
            {
                squareopen = true;
                break;
            }
            case "]":
            {
                squareclosed = true;
                break;
            }
            case "(":
            {
                parensopen = true;
                break;
            }
            case ")":
            {
                parensclosed = true;
                break;
            }
            default:
                break;
        }
    }

    return !(curlyopen != curlyclosed || parensopen != parensclosed || squareopen != squareclosed);
}

