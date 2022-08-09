Console.Write("Введите число");
int num = int.Parse(Console.ReadLine());
if (num % 2==0)
{
    Console.Write(num);
    Console.WriteLine("  является четным числом");
}
else
{
    Console.Write(num);
    Console.WriteLine("  является нечетным числом");
}
