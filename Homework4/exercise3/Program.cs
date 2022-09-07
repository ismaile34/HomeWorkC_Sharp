// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)


// Генерация массива
int[] genArray(int Lenght)
{
    int[] array = new int[Lenght];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 8);
        i++;
    }
    return array;
}

// Поиск второго максимального значения в массиве
int secmax(int[] MyArr)
{
    int max;
    int max2;
    if (MyArr[0] > MyArr[1])
    {
        max = MyArr[0];
        max2 = MyArr[1];
    }
    else
    {
        max = MyArr[1];
        max2 = MyArr[0];
    }
    for (int i = 0; i < MyArr.Length; i++)
    {
        if (MyArr[i] > max)
        {
            max2 = max;
            max = MyArr[i];
        }
        else if (MyArr[i] > max2 && MyArr[i] != max)
        {
            max2 = MyArr[i];
        }
    }
    return max2;
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

int[] array = genArray(9);
printArray(array);
secmax(array);
System.Console.WriteLine($"Второй максимум = {secmax(array)}");