// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());


Square(num);

void Square(int num)

{
   int a = 1;
   while (a <= num)
   {
      Console.WriteLine($"{a} | {Math.Pow(a, 3),3} |");
      a++;
   }
   Console.WriteLine("Введите положительное число");
}
