// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

// Поиск сумму элементов, стоящих на нечётных позициях.
int SearchSumM(int[] MyArr)
{
    int summ = 0;
    int i = 1;
    while (i < MyArr.Length)
    {
        summ+=MyArr[i];
        i+=2;
    }
    return summ;
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

int[] array = genArray(8);
printArray(array);
SearchSumM(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях. = {SearchSumM(array)}");

















