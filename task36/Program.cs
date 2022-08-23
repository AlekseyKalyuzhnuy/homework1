//Задача 36. Создать массив, заполненный случайными числами;
// Найти сумму элементов, стоящих на нечетных позициях.

Console.Clear();
Console.WriteLine("Введите число элементов массива");
int num = int.Parse(Console.ReadLine());

int[] array=GetArray(num);
Console.WriteLine(String.Join(", ", array));

int summ=SummNumberOddIndex(array);
Console.WriteLine($"сумма элементов нечечтных позиций массива равна:  {summ} ");


int[] GetArray(int count)
{
    int[] array=new int[count];
    for(int i=0; i<count; i++)
    {
       array[i]=new Random().Next(0,100); 
    }
    return array;
}


int SummNumberOddIndex(int [] arr)
{
    int sum=0;
    for(int i=1; i<array.Length; i=i+2)
    {
      sum+=array[i];
    } 
    return sum;
}
