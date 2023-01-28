// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FirstMatrix = new int[2, 2];
FillArray(FirstMatrix);
PrintArray(FirstMatrix);
Console.WriteLine();
int[,] SecondMatrix = new int[2, 2];
FillArray(SecondMatrix);
PrintArray(SecondMatrix);
int[,] ResultMatrix = new int[2, 2];

void MultiplyArray(int[,] FirstMatrix, int[,] SecondMatrix, int[,] ResultMatrix)
{
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < FirstMatrix.GetLength(1); k++)
            {
                result += FirstMatrix[i, k] * SecondMatrix[k, j];
            }
            ResultMatrix[i,j] = result;
        }
    }
}

MultiplyArray(FirstMatrix, SecondMatrix, ResultMatrix);
Console.WriteLine($"Прoизведение матриц: ");
PrintArray(ResultMatrix);