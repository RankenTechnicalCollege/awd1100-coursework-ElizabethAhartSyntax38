﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("write an Age");

int age=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("write a second Age!");

int age2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write a third RANDOM Age!");

int age3=Convert.ToInt32(Console.ReadLine());

Decimal Average =Convert.ToDecimal (age + age2 + age3)/3;

Console.WriteLine($"Average of Age is {Average:f}",Average);