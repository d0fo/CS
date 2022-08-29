// See https://aka.ms/new-console-template for more information
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            // Console.Write($"{matr[i, j]} ");
            Console.Write("{0,6:F2}", matr[i, j]);
        }
    Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {   
            matr[i,j] = new Random().Next(-10,11)+new Random().NextDouble();
        }
    }
}
double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArray(matrix);