int numFinish;
int num1=0;
Console.Write("Введите число ");
numFinish = int.Parse(Console.ReadLine());
while(num1<numFinish-1)
{
  num1=num1+2;
  Console.WriteLine(num1);
}
