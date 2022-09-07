// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Random rnd = new Random();
int x = rnd.Next(100 , 1000);
Console.WriteLine(x);
int s = 2;
int m = 1;
while (s > 1) {
     m *= 10;
     s--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);