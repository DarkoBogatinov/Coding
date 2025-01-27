﻿/*// Unit 2 {Exercise - Investigate string formatting basics}
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You save {0:C2} off the regulat {1:C2} price.", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);*/
/*// Unit 3 {Exercise - Explore string interpolation}
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3} Product");
Console.WriteLine($"Sub Total: {subtotal:C}");
Console.WriteLine($"Tax: {taxPercentage:P2}");
Console.WriteLine($"Total Billed: {total:C}");*/
/*// Unit 4 {Exercise - Discover padding and alignment}
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentID = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);*/
// Unit 5 and 6 {Exercise - Complete a challenge to apply string interpolation to a form letter}
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn*100:N2} %.");
Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = currentProduct.PadRight(20) + ($"{currentReturn*100:N2} %").PadRight(10) + ($"{currentProfit:C2}\n");
comparisonMessage += newProduct.PadRight(20) + ($"{newReturn*100:N2} %").PadRight(10) + ($"{newProfit:C2}");

Console.WriteLine(comparisonMessage);

Console.ReadLine()