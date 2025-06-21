// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your Name?");
string name =Console.ReadLine();

Console.WriteLine("What is your Address?");
string Address=Console.ReadLine();

Console.WriteLine("what is your City,State,and Zip?");
string cityStateZip=Console.ReadLine();

Console.WriteLine("How many T-shirts Purchased?");
double num =Convert.ToDouble( Console.ReadLine());
double num3 =Convert.ToDouble(num)*(14.99);
const float TAXRATE = .8f;
double num2 =Convert.ToDouble(num )* (14.99)/(TAXRATE);
Console.WriteLine("***************SALES RECEIPT********************");
Console.WriteLine( $"{name}");
Console.WriteLine($"{Address}");
Console.WriteLine($"{cityStateZip}");
Console.WriteLine("*********************************");
Console.WriteLine($"Total Price is {num3:c}");
Console.WriteLine($"plus tax {(num*14.99)*(.08)}");
Console.WriteLine($"Plus tax 0.8 Total Amount Due is {num3+ (num * 14.99) * (.08):c}");


