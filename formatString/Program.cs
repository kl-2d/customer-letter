﻿string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}. ");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
string cReturn = ($"{currentReturn:P2}");
string cProfit = ($"{currentProfit:C}");

string nReturn = ($"{newReturn:P2}");
string nProfit = ($"{newProfit:C}");


comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += cReturn.PadRight(10);
comparisonMessage += cProfit.PadLeft(2);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += nReturn.PadRight(10);
comparisonMessage += nProfit.PadLeft(2);


Console.WriteLine(comparisonMessage);