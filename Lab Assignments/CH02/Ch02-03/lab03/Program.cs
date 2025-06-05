// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Lab03!");
Console.WriteLine("Annual Raise!");
const float RAISERATE = 0.04f;
Console.WriteLine("Year   Bob    Fred   Will");
Console.WriteLine("2018   10000 20000  30000");
Console.WriteLine("2019   10400  20800  31200");
Console.WriteLine("2020   10816   21632  32448");
Console.WriteLine("What is your Name");
    string Name = Console.ReadLine();
Console.WriteLine($"The Projected Raise{RAISERATE}percent 0Yearly,RAISERATE");

Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!");
Console.WriteLine("please name Employee 1");
string Name1= Console.ReadLine();
Console.WriteLine("enter His or Her salary");
double salary=Convert.ToDouble (Console.ReadLine());
const float RAISERATE1 = 1.04f;
double Sum = (RAISERATE1 * salary) ;
double sum2 = (Sum * RAISERATE1);
Console.WriteLine($"yor Raise is 0.4 for the next two years {Name1}");
Console.WriteLine($"{Sum:c} for year 2025 and {sum2:c} for 2026");
Console.WriteLine("!!!!");
Console.WriteLine("please List employee 2");
String Name2= Console.ReadLine();
Console.WriteLine("What is his or her Salary?");
double Sum3=Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Enter Employee 3");
String Name3=Console.ReadLine();
Console.WriteLine("what is His or Her Salary?");
double Sum4=Convert.ToDouble (Console.ReadLine());
double SumEmp2 = (RAISERATE1 * Sum3);
double SumEmp2yr2 = (SumEmp2 *RAISERATE1) ;
double SumEmp3= Sum4 * RAISERATE1;
double SumEmp3yrs2= SumEmp3* RAISERATE1;
Console.WriteLine("!!!!!!!!!!!!!!!!");
Console.WriteLine($"{SumEmp2:c} !1for the year 2025 !{Name2} !!{SumEmp2yr2:c} for the year 2026");
Console.WriteLine($"{SumEmp3:c} !!for the year 2025 !{Name3}{SumEmp3yrs2:c} for the year 2026");







