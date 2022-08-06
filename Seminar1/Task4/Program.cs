Console.WriteLine("Enter first number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if(n2>max)
{
max=n2;
}
if(n3>max)
{
max=n3;
}
Console.Write("Biggest number from this three is: ");
Console.Write(max);
