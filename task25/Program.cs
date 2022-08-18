int GetMath(int a, int b);
int a;
int b;
int result =1;
int result =Math.Pow(a,b);
return result;

Console.Clear();
Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(GetMuth(a,b));

