// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int NumofSales = 0;
int AverageSale = 0;
int HighestSale = int.MinValue;
int LowestSale = int.MaxValue;
int Sum = 0;
const float TAXRATE = 1.08f;
do
{
    Console.WriteLine("What is the Item Amount?");
    int Sale = (Convert.ToInt32(Console.ReadLine()));
    if (Sale == 0)
    {
        break;
    }
    else if (Sale >= 1 )
    {
        NumofSales++;
        Sum = Sum+ Sale++;
        if (Sale > HighestSale)
        {
            HighestSale = Sale;

        }
        if (LowestSale > Sale)
        {
            LowestSale = Sale;
        }
    }
    else
    {
        Console.WriteLine("invalid input enter valid sale 1-any");
    }

}
while (true);
Console.WriteLine($"The Number of Items Bought is {NumofSales}");
Console.WriteLine($"The sum of Items bought is {Sum}");
Console.WriteLine($"The Average of Sales is {Sum / NumofSales}");
Console.WriteLine($"Plus Tax Amount is {TAXRATE} TOTAL DUE: {Sum*(TAXRATE):f}");



