// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = Convert.ToInt32(Console.ReadLine());
double x =(b2-b1)/(k1-k2);
double y =k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Coordinates of point of intersection of lines is: ({x};{y})");