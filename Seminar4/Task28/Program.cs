// See https://aka.ms/new-console-template for more information
int[] Array()
{
    int[] arr =new int[3];
    int[] brr = new int[3];
    for(int i=0; i<arr.Length; i++)
        {
            arr[i] = new Random().Next(1,6);
            int multi=1;
            for(int j=1; j<=arr[i];j++)
                {
                     multi=multi*j;
                }
            brr[i]=multi;
            Console.Write(arr[i]+" ");
        }
        return brr;
        
}
Console.WriteLine('['+string.Join(", ", Array())+']');
