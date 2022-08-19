// See https://aka.ms/new-console-template for more information
int[] arr =new int[8];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
Console.WriteLine('['+string.Join(", ", arr)+']');
int sum = 0;
for(int i = 0; i < arr.Length;i++)
{
    if(arr[i]%2==0) sum=sum+1;
}
Console.WriteLine($"Massive contain {sum} even numbers");