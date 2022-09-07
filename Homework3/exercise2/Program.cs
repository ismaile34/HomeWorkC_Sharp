//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат функции
}

int x = Prompt("Введите X > ");
int y = Prompt("Введите Y > ");
int z = Prompt("Введите Z > ");
int x1 = Prompt("Введите X1 > ");
int y1 = Prompt("Введите Y1 > ");
int z1 = Prompt("Введите Z1 > ");

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Невозможно вычислить координаты, точка на оси");
    return;
}
double distance = Math.Sqrt((x1 - x)*(x1 - x)+(y1 - y)*(y1 - y)+(z1 - z)*(z1 - z));
System.Console.WriteLine(distance);