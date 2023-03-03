Console.WriteLine(SquareIsWhite("a1")); // false
Console.WriteLine(SquareIsWhite("b1")); // true
Console.WriteLine(SquareIsWhite("e6")); // true
Console.WriteLine(SquareIsWhite("h8")); // false
Console.WriteLine(SquareIsWhite("e7")); // false
Console.WriteLine(SquareIsWhite("b3")); // true


// thanks, ChatGPT
bool SquareIsWhite(string c) {
    return (c[0] == 'a' || c[0] == 'c' || c[0] == 'e' || c[0] == 'g') ?
       ((c[1] == '1' || c[1] == '3' || c[1] == '5' || c[1] == '7') ? false : true) :
       ((c[1] == '1' || c[1] == '3' || c[1] == '5' || c[1] == '7') ? true : false);
}

// crazy version
bool SquareIsWhite(string coordinates) {
    bool flip = (coordinates[0] == 'a' || coordinates[0] == 'c' || coordinates[0] == 'e' || coordinates[0] == 'g') ? false : true;
    return (coordinates[1] == '1' || coordinates[1] == '3' || coordinates[1] == '5' || coordinates[1] == '7') ? flip : !flip;
}

// my first version
/*bool SquareIsWhite(string coordinates) {
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
*/