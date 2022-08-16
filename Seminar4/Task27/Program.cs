// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter integer number");
int a = Convert.ToInt32(Console.ReadLine());
string str = Math.Abs(a).ToString();
int[] b = new int[str.Length];
int sum = 0;
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
     sum = sum+ b[i];
}
if (a < 0) 
{
    sum=sum - b[0]*2;
    Console.WriteLine($"Result is: {sum}");
}
else Console.WriteLine($"Sum of the digits of this number is: {sum}");

