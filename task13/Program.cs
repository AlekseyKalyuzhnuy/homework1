Console.Write("Введите число до 100 000  ");
int num = int.Parse(Console.ReadLine());
int num1=0;
if ((num>99) && (num<1000))
{      
num1=num % 10;
}
if((num>999) && (num< 10000))
{
  num1=num %100/10;
}    
if((num>9999) && (num<100000))
{
num1=num/100%10;
}
if(num<100)
{
Console.WriteLine("третьей цифры нет");
}
if(num1>0)
{
  Console.WriteLine(num1);  
}