// задача 50 программа принимает на ввод позиции элементов в двумерном массиве
// Возвращает значение данного элемента или соощает что такого элемента нет


Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int row= int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols= int.Parse(Console.ReadLine());



int[,] arr= GetArray(row, cols, -10, 10);
PrintArray(arr);

Console.WriteLine("Для поиска элемента Введите номер строки массива: ");
int datan = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер строки массива: ");
int datam = int.Parse(Console.ReadLine());

if(datan>row ||datam>cols)
{
    Console.WriteLine("данный элемент в массиве отсутствует");
}
else
{
    Console.WriteLine($"знаяение элемента в строке {datan} и столбце {datam} равно {arr[datan,datam]}");
}


// создание двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue) 

{

    int [,] array = new int [m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
           array[i,j]=new Random().Next(minValue,maxValue);
        }
    }
    return array;
}


//  печать двумерного массива

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


