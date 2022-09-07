//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int SumNumbers(int M, int N)
{
    if (M%2==0) return M;
    return M + SumNumbers(M + 1, N);
}

int M = Prompt("Введите число M > ");
int N = Prompt("Введите число N > ");
SumNumbers(M, N);
System.Console.WriteLine($"Сумма чисел от M до N = {SumNumbers(M, N)}");