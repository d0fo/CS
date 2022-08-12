// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter integer number");
long n = Convert.ToInt64(Console.ReadLine());
char[] array = n.ToString().ToCharArray();
if (n>99) Console.WriteLine($"Third left digit in this number is: {array[2]}");
else if (n<-99) Console.WriteLine($"Third left digit in this number is: {array[3]}");
else Console.WriteLine("There is no third left digit in this number");

