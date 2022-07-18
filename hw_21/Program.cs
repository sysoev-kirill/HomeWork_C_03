
Console.WriteLine("введите координаты точки №1");
Console.Write("X, ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y, ");
double y = Convert.ToInt32(Console.ReadLine());
Console.Write("Z, ");
double z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты точки №2");
Console.Write("X2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());


double Distance(double X, double Y, double Z, double X2, double Y2, double Z2)
{
   return Math.Round(Math.Sqrt(Math.Pow((X2 - X), 2) + Math.Pow((Y2 - Y), 2) + Math.Pow((Z2 - Z), 2)), 2);
}

double res = Distance(x, y, z, x2, y2, z2);

Console.WriteLine($"Расстояние между точками составляет: {res}");