//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int Akermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akermann(m - 1, 1);
    }
    return Akermann(m - 1, Akermann(m, n - 1));
}

int M = Prompt("Введите число M > ");
int N = Prompt("Введите число N > ");
Akermann(M, N);
System.Console.WriteLine($"A({M},{N}) = {Akermann(M,N)}");