// See https://aka.ms/new-console-template for more information
int[] a = new int [123]; 
    for(int i=0; i<a.Length; i++)
    {
        a[i] = new Random().Next(0,1000);
    }
Console.WriteLine('['+string.Join(", ", a)+']');
int sum = 0;
for(int i = 0; i < a.Length;i++)
{
    if(a[i]<=99&a[i]>=10) sum=sum+1;
}
Console.WriteLine($"Massive contain {sum} numbers in [10;99] interval");