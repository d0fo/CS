// See https://aka.ms/new-console-template for more information
int[] Array()
{
    int[] arr =new int[8];
    for(int i=0; i<8; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}
Console.WriteLine('['+string.Join(", ", Array())+']');