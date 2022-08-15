Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());
int num1=0; 
int num2=0;
int num3=0;
int num4=0;
int num5=0; 
if (num < 10000 | num >99999)
{
    Console.WriteLine("Ввведенное число не является пятизначным");
}
 else
{
    num1=num/10000;
    num2=num/1000%10;
    num3=num/100%10;
    num4=num%100/10;
    num5=num%10;
}
if((num1==num5) &&  (num2==num4))
{
    Console.WriteLine ($"{num} -является палинромом");
}
else
{
    Console.WriteLine($"{num} - не является палинромом");
}

