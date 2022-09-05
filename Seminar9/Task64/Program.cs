// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
void PrintNum(int n)
{
    if(n==0) return;
    Console.Write(n+" ");
    PrintNum(n-1);
}
PrintNum(number);
