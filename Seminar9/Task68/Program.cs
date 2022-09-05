// See https://aka.ms/new-console-template for more information
int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n > 0 & m == 0)
    {
        return AkkermanFunction(n - 1, 1);
    }
    else
    {
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    }

}
int m = 2, n = 3;
Console.WriteLine(AkkermanFunction(n, m));