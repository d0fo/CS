// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter M number:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N number:");
int N = Convert.ToInt32(Console.ReadLine());
int Sum(int number1, int number2)
{
    if (number1 > number2) return 0;
    return number1 + Sum(number1 + 1, number2);
}

if (M < N)
{
    Console.WriteLine("The sum of elements between M and N is:"+Sum(M, N));
}
else
{
    Console.WriteLine("The sum of elements between M and N is:"+Sum(N, M));
}