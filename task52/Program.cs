// задача 52 задать двумерный массив из целых чисел
// найти среднее арифметическое элементов в кажом столбце


Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int row= int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols= int.Parse(Console.ReadLine());



int[,] arr= GetArray(row, cols, -10, 10);
PrintArray(arr);
MidArray(arr);


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

void MidArray(int[,] array)
{
     
    for (int j=0; j<array.GetLength(1); j++)
    {
        double sumAr=0;
        double middleAr=array[1,1];
        for(int i=0; i<array.GetLength(0); i++)
        {
           sumAr=sumAr+array[i,j];
           middleAr= sumAr/array.GetLength(0);
        }
        Console.WriteLine($"среднее арифметическое элементов в столбце {j}: {middleAr:f2}");
    }
}
