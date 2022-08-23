// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter lenght of the massive");
int n = Convert.ToInt32(Console.ReadLine());
double[] a = new double [n];
for(int i =0; i<=a.Length-1;i++)
    {
        Console.WriteLine($"Enter {i+1} element of massive");
        a[i]=Convert.ToDouble(Console.ReadLine());
    }
Console.WriteLine('['+string.Join(", ", a)+']');
double min = a[0];
double max = a[0];
for(int i=0; i<=a.Length-1; i++)
   {
         if(max<a[i]) max=a[i];
         if(min>a[i]) min=a[i];
   }

Console.WriteLine($"Difference between max and min elemnt is: {max} - {min} = {max-min}");


