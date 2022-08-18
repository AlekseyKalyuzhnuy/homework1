int GetMath(int num1, int num2)
{
   int result =(int) Math.Pow(num1, num2 );
   return result;
}

Console.Clear();
Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(GetMath(a,b));

//  вводим два числа и возводим первое число в степень второго (через оператор Math)