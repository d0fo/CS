// See https://aka.ms/new-console-template for more information
int[] a = new int [8]; 
    for(int i=0; i<a.Length; i++)
    {
        a[i] = new Random().Next(0,11);
    }
Console.WriteLine('['+string.Join(", ", a)+']');
int sum = 0;
for(int i = 1; i < a.Length;i+=2)
{
   sum=sum+a[i];
}
Console.WriteLine($"Sum of the elements placed on uneven places is {sum}");