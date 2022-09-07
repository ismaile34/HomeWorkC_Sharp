// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void SortArrayLines(int[,] array) // Функция сортировки строк массива по убыванию
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
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
int[,] matrix = new int[4, 4];
FillArray(matrix);
System.Console.WriteLine($"\nЗаданный массив: ");
PrintArray(matrix);
System.Console.WriteLine($"\nОтсортированный массив: ");
SortArrayLines(matrix);
PrintArray(matrix);