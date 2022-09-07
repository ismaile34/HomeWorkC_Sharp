//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.


int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

void SumNumbers(int M, int N)
{
    if (M <= N)
    {
        if (M <= N && M % 2 == 0)
        {
            System.Console.WriteLine($"{M}");
        }
        SumNumbers(M + 1, N);
    }
}

int M = Prompt("Введите число M > ");
int N = Prompt("Введите число N > ");
System.Console.WriteLine($"Четные числа от {M} до {N}: ");
SumNumbers(M, N);