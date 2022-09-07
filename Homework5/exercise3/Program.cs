﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Генерация массива
double[] genArray(int Lenght)
{
    double[] array = new double[Lenght];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = Math.Round (new Random().NextDouble() * new Random().Next(1, 8), 1);
        i++;
    }
    return array;
}

// Поиск разницы между максимальным и минимальным значениями в массиве
double MinMax(double[] MyArr)
{
    double min = MyArr[0];
    double max = MyArr[0];
    double dif = 0;
    for (int i = 1; i < MyArr.Length; i++)
    {
        if (MyArr[i] < min)
        {
            min = MyArr[i];
        }
        if (MyArr[i] > max)
        {
            max = MyArr[i];
        }
        dif = max - min;
    }
    return dif;
}

// Вывод массива в консоль
void printArray(double[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        System.Console.Write($"{array[count]}\t");
        count++;
    }
    Console.WriteLine();
}

double[] array = genArray(4);
printArray(array);
MinMax(array);
System.Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве = {MinMax(array)}");