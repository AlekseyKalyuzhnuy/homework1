int GetSum(int number)

{
    int num2=number;
    int num1=number;
    int sum=0;
    while(num1 >0)
    {
        num2 = num1%10;
        sum +=num2;
        num1 /=10;
    }
    return sum;

}
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(num));
// считает сумму цифр в числе