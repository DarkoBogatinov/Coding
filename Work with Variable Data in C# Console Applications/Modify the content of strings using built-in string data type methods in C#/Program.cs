/*// Unit 2 {Exercise - Use the string's IndexOf() and Substring() helper methods}
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/
/*// Unit 3 {Exercise - Use the string's IndexOfAny() and LastIndexOf() helper methods}
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters.
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through
// the characters in the string. This time, use the closing
// position of the previous iteration as the starting index for the
// next open symbol. So, you need to initialize the closingPosition
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the Indecof method to specify
    // that the search for the matchingSymbol should start at the openingPosition in the string.

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}*/
/*// Unit 4 {Exercise - Use the Remove() and Replace() methods}
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);*/
// Unit 5 {Exercise: Complete a challenge to extract, replace, and remove data from an input string}
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int startIndex = input.IndexOf("<span>");
int endIndex = input.IndexOf("</span>");

quantity = input.Substring(startIndex + 6, endIndex - startIndex - 6);

startIndex = input.IndexOf("<div>");
endIndex = input.IndexOf("</div>");

output = input.Remove(startIndex, startIndex + 5);
endIndex = output.IndexOf("</div>");
output = output.Remove(endIndex);
output = output.Replace("&trade", "&reg");

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);