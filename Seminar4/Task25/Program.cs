// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number b:");
int b = Convert.ToInt32(Console.ReadLine());
int degree = 1;
for (int i=1; i <= b; i++)
{
    degree = degree *a; 
}
Console.WriteLine($"Number a in b degeree is: {degree}");

