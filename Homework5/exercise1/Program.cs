// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

// Генерация массива
int[] GenArray(int Lenght)
{
    int[] array = new int[Lenght];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(100, 1000);
        i++;
    }
    return array;
}

// Поиск четных чисел в массиве
int SearchPosNum(int[] MyArr)
{
    int count = 0;
    for (int i = 0; i < MyArr.Length; i++)
    {
        
        if (MyArr[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

// Вывод массива в консоль
void printArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        System.Console.Write($"{array[count]}\t");
        count++;
    }
    Console.WriteLine();
}

int[] array = GenArray(10);
printArray(array);
SearchPosNum(array);
System.Console.WriteLine($"Количество четных чисел = {SearchPosNum(array)}");