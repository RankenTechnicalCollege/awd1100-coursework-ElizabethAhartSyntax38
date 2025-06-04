// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

Console.WriteLine("Lab04!");
Console.WriteLine("CarRental 100 plus.5 per Mile");
Console.WriteLine("How many Days needed?");
double days =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Estimate Miles?");
double mile=Convert.ToDouble(Console.ReadLine());
double mileTotal = Convert.ToDouble( mile * .5f);
double balance = days * 100;
double totalBalance= balance+ mileTotal;
Console.WriteLine($"you balance is {balance:c}, Total Balance {totalBalance:c},balance");
    


