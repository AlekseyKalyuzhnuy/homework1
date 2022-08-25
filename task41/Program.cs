// задача 41 пользователь вводит с клавиатуры М чисел
// программа должна посчитать сколько "0" ввел пользователь;


Console.Clear();
Console.WriteLine(" Выбереите количество цифр для ввода ");
int m = int.Parse(Console.ReadLine());
int count=0;
int positiv=0;
while (count< m)
{
Console. WriteLine(" Введите число"); 
int num = int.Parse(Console.ReadLine());
count+=1;
if (num>0)
  {
    positiv+=1; 
  }
}
 Console.WriteLine($"количество положительных чисел -{positiv}");

