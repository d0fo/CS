// See https://aka.ms/new-console-template for more information
int Multiplication (int n)
{
    if(n==1) return 1;
    else 
    {
        return n*Multiplication(n-1);
    }
}
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Product numbers from 1 to your number is: "+Multiplication(Math.Abs(number)));

