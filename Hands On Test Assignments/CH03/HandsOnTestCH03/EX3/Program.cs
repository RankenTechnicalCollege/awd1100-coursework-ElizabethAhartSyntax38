// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your Name?");
string name =Console.ReadLine();
Console.WriteLine("What is your Address?");
string Address=Console.ReadLine();
Console.WriteLine("what is your City,State,and Zip?");
string cityStateZip=Console.ReadLine();
Console.WriteLine("How many T-shirts Purchased?");
string num = Console.ReadLine();
const float TAXRATE = 0.8f;
double num2 =Convert.ToDouble(num) * (14.99)*(TAXRATE);
Console.WriteLine("Total Price is {0:C}",num2);

Console.WriteLine("Plus tax 0.8 Amount Due is (salesTax)+(total Price)");


