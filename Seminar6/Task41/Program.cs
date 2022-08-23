// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter amount of numbers");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int [n];
for(int i =0; i<=a.Length-1;i++)
    {
        Console.WriteLine($"Enter {i+1} number");
        a[i]=Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine('['+string.Join(", ", a)+']');
int count =0;
for(int i=0; i<=a.Length-1; i++)
   {
         if(a[i]>0) count=count+1;
   }
   Console.WriteLine($"Amount of positive numbers is: {count}");