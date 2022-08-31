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
void ReplaceRows(int[,]matr)
{
    for (int i=0; i<matr.GetLength(1);i++)
    {
        int temp = matr[0,i];
        matr[0,i] = matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i]=temp;
    }
}
ReplaceRows(matrix);
Console.WriteLine();
PrintArray(matrix); 
