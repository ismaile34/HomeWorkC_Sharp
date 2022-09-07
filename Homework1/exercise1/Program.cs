Console.WriteLine("Введите первое число >");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число >");
int B = Convert.ToInt32(Console.ReadLine());
   if (A > B)
   {
    Console.WriteLine("max = "+A + ", min = "+B);
   }
   else if (A == B)
   {
    Console.WriteLine(A + " равно " + B);
   }
   else
   {
    Console.WriteLine("max = "+B + ", min = "+A);
   }