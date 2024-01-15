/*// Unit 2 {Exercise - Discover Sort() and Reverse()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}*/
/*// Unit 3 {Exercise - Explore Clear() and Resize()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

//Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
//if (pallets[0] != null)
//   Console.WriteLine($"After: {pallets[0].ToLower()}");
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}*/
/*// Unit 4 {Exercise - Discover Split() and Join()}
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}*/
/*// Unit 5 and 6 {Exercise - Complete a challenge to reverse words in a sentence}
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(" ");
string[] updatedPangramArray = new string[pangramArray.Length];
string updatedPangram = "";
int i = 0;

foreach (var word in pangramArray)
{
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    updatedPangramArray[i] = String.Join("", wordArray);
    i++;
}

updatedPangram = String.Join(" ", updatedPangramArray);
Console.WriteLine(updatedPangram);*/
// Unit 7 {Exercise - Complete a challenge to parse a astring of orders, sort the orders and tag possivle errors}
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIds = orderStream.Split(',');

Array.Sort(orderIds);

foreach(string order in orderIds)
{
    if (order.Length != 4)
        Console.WriteLine($"{order}\t- Error");
    else
        Console.WriteLine(order);
}


Console.ReadLine();