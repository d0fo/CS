// See https://aka.ms/new-console-template for more information
void PrintArray(int[,,] matr)
{
    for(int i=0; i< matr.GetLength(0);i++)
    {
        for (int j=0; j< matr.GetLength(1);j++)
        {
            for(int k=0;k<matr.GetLength(2);k++)
            {
                Console.Write($"{matr[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
void FillArray(int[,,] matr)
{
    for(int i=0; i< matr.GetLength(0);i++)
    {
        for (int j=0; j< matr.GetLength(1);j++)
        {
            for(int k=0;k<matr.GetLength(2);k++)
            {
                matr[i,j,k] = new Random().Next(0,10);
            }        
        }
    }
}
int[,,] matrix = new int[2,2,2];
FillArray(matrix);
PrintArray(matrix);
