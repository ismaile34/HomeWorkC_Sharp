// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int step(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result*=a;
    }
    if (b==0){
        result = 1;
    }
return result;
}

int a = Prompt("Введите число > ");
int b = Prompt("Введите степень в которую хотите возвести это число > ");
System.Console.WriteLine(step(a, b));
