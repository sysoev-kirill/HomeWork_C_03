// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число:   ");
int num = Convert.ToInt32(Console.ReadLine());

string Poliandr(int Num)
{
   int rev = 0;
   int n = Num;
   int rem;

   while (Num > 0)
   {
      rem = Num % 10;
      rev = rev * 10 + rem;
      Num = (Num / 10);
   }
   if (n == rev) return "Да - это число палиндр!";
   return "Нет - это число не палиндр!";
}

string result = Poliandr(num);

Console.WriteLine(result);