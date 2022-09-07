// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int MinSumLine(int[,] matrix) //Функция поиска строки с минимальной суммой
{
    int minSumLine = 0;
    int sumLine = SumLineElements(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(matrix, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    return minSumLine;
}
int SumLineElements(int[,] matrix, int i) //Функция суммирования строк массива
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}

int[,] FillArray(int[,] matrix) // Функция создания и заполнения двумерного массива случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}


void PrintArray(int[,] matrix) // Функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}]\t");
        }
        Console.WriteLine();
    }
}
int i = 0;
int[,] matrix = new int[5, 3];
FillArray(matrix);
PrintArray(matrix);
SumLineElements(matrix, i);
MinSumLine(matrix);
Console.WriteLine($"\nСтрокa с наименьшей суммой {SumLineElements(matrix, i)} элементов > {MinSumLine(matrix) +1} строка");