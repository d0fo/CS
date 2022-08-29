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
void AverageColumns()
{
    double sum=0;
    Console.WriteLine("Averege of each columns are: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            for (int i = 0; i<matrix.GetLength(0);i++)
            {
                sum=sum+matrix[i,j];  
            }
            Console.Write("{0,5:F1}",sum/3);
            sum=0;
        }
}
AverageColumns();