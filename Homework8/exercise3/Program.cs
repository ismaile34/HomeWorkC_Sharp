// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int[,] matrix) // Функция создания и заполнения двумерного массива случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
        }
    }
    return matrix;
}

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] productMatrix)
{
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            productMatrix[i, j] = sum;
        }
    }
}

void PrintArray(int[,] matrix) // Функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] firstMatrix = new int[2, 2];
FillArray(firstMatrix);
Console.WriteLine($"\nfirstMatrix:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[2, 2];
FillArray(secondMatrix);
Console.WriteLine($"\nsecondMatrix:");
PrintArray(secondMatrix);

int[,] productMatrix = new int[2, 2];

MultiplyMatrix(firstMatrix, secondMatrix, productMatrix);
Console.WriteLine($"\nproductMatrix:");
PrintArray(productMatrix);