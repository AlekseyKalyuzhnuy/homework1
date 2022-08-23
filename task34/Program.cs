//Задача №34 задать массив из случайных положительныз трехзначныих чисел;
// Посчитать количество четныех числе в массиве;

Console.Clear();
Console.WriteLine("Введите число элементов массива");
int num = int.Parse(Console.ReadLine());

int[] array=GetArray(num);
Console.WriteLine(String.Join(", ", array));

int summ=NumberPositive(array);
Console.WriteLine($"количество четных чисел в массиве {summ} ");


int[] GetArray(int count)
{
    int[] array=new int[count];
    for(int i=0; i<count; i++)
    {
       array[i]=new Random().Next(100,1000); 
    }
    return array;
}

int NumberPositive(int [] arr)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
      if (array[i]%10==0) sum+=1;
    } 
    return sum;
}

