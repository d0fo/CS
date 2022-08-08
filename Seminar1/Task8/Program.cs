Console.WriteLine("Enter integer number");
int n = Convert.ToInt32(Console.ReadLine());
int i=1;
if(n>0)
{
    Console.WriteLine("Even integer numbers between this nimber and 1 are:");
    while(i<n)
    {
    if(i%2==0)
    {
        Console.WriteLine(i);
    }
    i++;
    }
}
if(n<0)
Console.WriteLine("Even integer numbers between this nimber and 1 are:");
{
    while(i>n)
    {
    if(i%2==0)
    {
        Console.WriteLine(i);
    }
    i=i-1;  
    }
}

if(n==0)
{
    Console.WriteLine("There is no integer numbers between this numbers and 1");
}