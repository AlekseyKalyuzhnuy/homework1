Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int k=num;
if (num<0) k=-num;
for(int i=1; i<=k; i++)
Console.WriteLine($"i={Math.Pow(i,3)}");
