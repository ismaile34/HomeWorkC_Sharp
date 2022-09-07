//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int Cube(int N)
{
    int result = 0;
    for (int i = 1; i <= N; i++)
    {
        result = (i * i * i);
        Console.WriteLine(result);
    }
    return result;

}

int N = Prompt("Введите число >");
Cube(N);
