int GetMath(int num1, int num2);
{
   int result = num1;
   for (int i=1; i<=num2; i++)
   {
     result *= num1; 
     return result;
   } 
}

Console.Clear();
Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(GetMath(a,b));
