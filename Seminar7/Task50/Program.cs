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
Console.WriteLine("Enter the row number:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the column number:");
int column = Convert.ToInt32(Console.ReadLine());
if (row<=3&column<=4) Console.WriteLine($"{matrix[row-1,column-1]} is the element of entered values of row and column");
else Console.WriteLine("There is no such an element in this matrix");
