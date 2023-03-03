Console.WriteLine(SquareIsWhite("a1")); // false
Console.WriteLine(SquareIsWhite("b1")); // true
Console.WriteLine(SquareIsWhite("e6")); // true
Console.WriteLine(SquareIsWhite("h8")); // false
Console.WriteLine(SquareIsWhite("e7")); // false
Console.WriteLine(SquareIsWhite("b3")); // true


bool SquareIsWhite(string coordinates) {
    bool flip;
    switch (coordinates[0]) {
        case 'a' or 'c' or 'e' or 'g': {
            flip = false;
            break;
        }
        default: {
            flip = true;
            break;
        }
    }
    switch (coordinates[1]) {
        case '1' or '3' or '5' or '7': {
            return flip;
        }
        default: {
            return !flip;
        }
    }
}
