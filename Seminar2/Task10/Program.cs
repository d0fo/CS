// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter tree-digit number");
int n=Convert.ToInt32(Console.ReadLine());
if (n<=100|n>999) Console.WriteLine("This is no tree-digit number");
else
{
int a=n/10%10;
Console.WriteLine("Second digit is: " +a);
}
