Console.Clear();
Console.WriteLine("Введите координаты точек.");
Console.WriteLine("Введите X1: ");
int x1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int y1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1: ");
int z1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2: ");
int x2= int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int y2= int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2: ");
int z2= int.Parse(Console.ReadLine());

double c= Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"C = {c:f2}");