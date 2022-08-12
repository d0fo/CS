// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine("Cubes from 1 to this number are:");
while(count<=n)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}
