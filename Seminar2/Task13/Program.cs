﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter integer number");
long i = Convert.ToInt64(Console.ReadLine());
char[] array = i.ToString().ToCharArray();
Console.WriteLine($"Third left digit in this number is: {array[2]}");
