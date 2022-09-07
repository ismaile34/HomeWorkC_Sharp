// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int summ(int number)
{
    int result = 0;
    int temp = 0;
    while (number > 0)
    {
        temp = number % 10;
        result = result + temp;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число > ");
System.Console.WriteLine(summ(number));