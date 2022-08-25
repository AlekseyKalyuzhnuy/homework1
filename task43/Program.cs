//Задача найти точки пересечения двух прямых, заданных уровнениями

Console.Clear();
Console.WriteLine(" Введите b1 ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите k1 ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите b2 ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите k2 ");
int k2 = int.Parse(Console.ReadLine());

double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine($"Точка пересечения двух прямых имеет координаты: x={x}, y={y}.");
