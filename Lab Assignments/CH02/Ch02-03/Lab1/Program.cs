Console.WriteLine("please enter a number of miles");
double numMiles = Convert.ToDouble(Console.ReadLine());
double numKilometers = numMiles * 1.6;
Console.WriteLine($"{numMiles} miles is {numKilometers} kilometers.");
