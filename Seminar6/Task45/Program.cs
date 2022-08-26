// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int [n];
int[] b = new int [n];
for(int i = 0; i <= a.Length-1; i++)
{
    a[i] = new Random().Next(-10,11);
    b[i]=a[i];
}
Console.WriteLine('['+string.Join(", ", a)+']');
Console.WriteLine('['+string.Join(", ", b)+']');