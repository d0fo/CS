// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter five-digit positive number");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n/10000%10;
int n2 = n/1000%10;
int n3 = n/100%10;
int n4 = n/10%10;
int n5 = n%10;
if(n1==n5 & n2==n4) Console.WriteLine("Yes, this number is palindrome");
else Console.WriteLine("No, this number is not palindrome");