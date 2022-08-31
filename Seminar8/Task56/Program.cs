void PrintArray(int[,] matr)
{
    for(int i=0; i< matr.GetLength(0);i++)
    {
        for (int j=0; j< matr.GetLength(1);j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {   
            matr[i,j] = new Random().Next(0,10);
        }
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
void SumMinimal(int[,]matr)
{
    int [] sum = new int [3];
    int SumTemp=0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {   
            SumTemp = SumTemp+matr[i,j];
        }
    sum[i]=SumTemp;  
    SumTemp=0;
    }
    int SumMin=sum[0];
    int IndexMin=0;
    for(int k = 0; k<sum.Length;k++)
    {
        if(SumMin>sum[k]) 
        {
            SumMin=sum[k];
            IndexMin=k;
        }
    }
    Console.WriteLine($"{IndexMin+1} is the row with minimal sum of elements");
}
SumMinimal(matrix);
