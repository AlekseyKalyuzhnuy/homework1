Console.Write("Введите трёхзначное число  ");
int num = int.Parse(Console.ReadLine());
int num1=num % 100;
int num2=num1 / 10;
Console.WriteLine(num2);
