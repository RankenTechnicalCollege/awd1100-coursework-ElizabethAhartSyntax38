// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

Console.WriteLine("Lab04!");
Console.WriteLine("CarRental 100 plus.5 per Mile");
Console.WriteLine("How many Days needed?");
double days =Convert.ToDouble(Console.ReadLine());
double balance = days / 100;
Console.WriteLine("you balance is {0:c}", balance);
    


