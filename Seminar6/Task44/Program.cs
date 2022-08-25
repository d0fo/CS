// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
int[] fibonacсhi = new int [number];
fibonacсhi[0]=0;
fibonacсhi[1]=1;
for(int i = 2;i<number;i++)
{
    fibonacсhi[i]=fibonacсhi[i-1]+fibonacсhi[i-2];
}
Console.WriteLine($"First {number} elements of Fibonacсhi sequence are: "+string.Join(", ", fibonacсhi));
