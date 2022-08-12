// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter X coordinare of first point");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y coordinare of first point");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Z coordinare of first point");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter X coordinare of second point");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y coordinare of second point");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Z coordinare of second point");
double z2 = Convert.ToDouble(Console.ReadLine());
double lenght = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"The length between two points is: "+lenght);