// Задача 38. Создать массив вещественных чисел;
// Найти разница между максимальным и минимальным элементами массива.

Console.Clear();
Console.WriteLine("Введите число элементов массива");
int num = int.Parse(Console.ReadLine());

int[] array=GetArray(num);
Console.WriteLine(String.Join(", ", array));

int Max=MaxNumber(array);
Console.WriteLine($"максимально число в массиве: {Max} ");

int Min=MinNumber(array);
Console.WriteLine($"минимальное число в массиве: {Min} ");


int delta= Max-Min;
Console.WriteLine($"РАЗНИЦА РАВНА: {delta} ");

int[] GetArray(int count)
{
    int[] array=new int[count];
    for(int i=0; i<count; i++)
    {
       array[i]=new Random().Next(0,100); 
    }
    return array;
}


int MaxNumber(int [] arr)
{
    int max= array[0];
    for(int i=0; i<array.Length; i++)
    {
      if (array[i]> max) max=array[i];
    } 
    return max;
}

int MinNumber(int [] arr)
{
    int min= array[0];
    for(int i=0; i<array.Length; i++)
    {
      if (array[i]< min) min=array[i];
    } 
    return min;
}
