// See https://aka.ms/new-console-template for more information
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
void DescendingOrder(int[,]matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {   
            for(int k = j+1;k<matr.GetLength(1);k++)
            {
                if(matr[i,k]>matr[i,j])
                {
                    temp=matr[i,j];
                    matr[i,j]=matr[i,k];
                    matr[i,k]=temp;
                }
            }
        }
    }
}
DescendingOrder(matrix);
Console.WriteLine();
PrintArray(matrix); 
