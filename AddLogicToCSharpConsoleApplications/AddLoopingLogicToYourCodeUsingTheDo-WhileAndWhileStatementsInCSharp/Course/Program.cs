/*// Unit 2
using System.Xml;

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");*/
/*// Unit 3 and 4
int heroHealthPoints = 10;
int monsterHealthPoints = 10;
Random random = new Random();
int attackPoints = random.Next(1, 11);

do
{
    monsterHealthPoints -= attackPoints;
    if (monsterHealthPoints < 0)
    {
        monsterHealthPoints = 0;
        Console.WriteLine("Hero wins!");
        break;
    }
    else
    {
        Console.WriteLine($"The monster lost {attackPoints} points and has {monsterHealthPoints} points remaining.");
    }
    attackPoints = random.Next(1, 11);
    heroHealthPoints -= attackPoints;
    if (heroHealthPoints < 0)
    {
        heroHealthPoints = 0;
        Console.WriteLine("Monster wins!");
        break;
    }
    else
    {
        Console.WriteLine($"The hero lost {attackPoints} points and has {heroHealthPoints} points remaining.");
    }
    attackPoints = random.Next(1, 11);
} while (true);*/
// Unit 5 and 6
/*string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least trhee characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);*/

/*// Code project 1
string userInput = "";
bool validNumber = false;
int userInputInteger = 0;

Console.WriteLine("Please write an integer number between 5 and 10:");
do
{
    userInput = Console.ReadLine();
    validNumber = int.TryParse(userInput, out userInputInteger);
    if (validNumber == true && (userInputInteger >= 5 && userInputInteger <= 10))
        break;
    else
    {
        Console.WriteLine("Wrong input, please try again: ");
    }
} while (true);

Console.WriteLine("Number accepted.");*/
/*// Code project 2

string? readResult;
bool writeResult = true;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    readResult = Console.ReadLine();
    readResult = readResult.Trim();
    readResult = readResult.ToLower();
    switch (readResult)
    {
        case "administrator":
            readResult = "Administrator";
            writeResult = false;
            break;
        case "manager":
            readResult = "Manager";
            writeResult = false;
            break;
        case "user":
            readResult = "User";
            writeResult = false;
            break;
        default:
            Console.WriteLine($"The role name that you entered,  \"{readResult}\" is not valid. enter your role name (Administrator, Manager, or User)");
            continue;
    }
} while (writeResult);

Console.WriteLine($"Your unput value ({readResult}) has been accepted.");*/
// Code project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string helpingString = "";

foreach(string myString in myStrings)
{
    helpingString = myString.TrimStart();
    while(periodLocation != -1)
    {
        periodLocation = helpingString.IndexOf(".");
        if (periodLocation == -1) break;
        Console.WriteLine(helpingString.Remove(periodLocation));
        helpingString = helpingString.Substring(periodLocation + 1);
        helpingString = helpingString.TrimStart();
    }
    Console.WriteLine(helpingString);
}