Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());
if (num < 10000 | num >99999)
{
    Console.WriteLine("Ввведенное число не является пятизначным");
    break;
}
 else
{
    int num1=num/10000;
    int num2=num/1000%10;
    int num3=num/100%10;
    int num4=num%100;
    int num5=num%10;
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(num3);
    Console.WriteLine(num4);
    Console.WriteLine(num5);
}