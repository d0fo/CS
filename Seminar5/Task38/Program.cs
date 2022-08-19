// See https://aka.ms/new-console-template for more information
double[] a = new double [8]; 
double min = 0;
double max = 0;
    for(int i=0; i<a.Length; i++)
    {
        a[i] = new Random().Next(0,11);
        if(a[i]>max) max=a[i];
        if(a[i]<min) min=a[i];
    }
Console.WriteLine('['+string.Join(", ", a)+']');
Console.WriteLine($"Difference between max and min elemnt is: {max}-{min}={max-min}");


