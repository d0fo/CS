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
int[,] matrix1 = new int[2,2];
int[,] matrix2 = new int[2,2];
int[,] matrix3 = new int[2,2];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
void MultiArray(int[,]matr)
{     
    Console.WriteLine("Multiplication of this matrix`s is:");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matr[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
}
MultiArray(matrix3);
PrintArray(matrix3);