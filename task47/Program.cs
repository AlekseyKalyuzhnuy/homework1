//задача 47 Задать двумерный массив размером MxN, заполненный случайными вещественными числами

Console.Clear();

Console.WriteLine("Введите колиечство строк массива: ");
int row= int.Parse(Console.ReadLine());
Console.WriteLine("Введите колиечство столбцов массива: ");
int cols= int.Parse(Console.ReadLine());

double[,] arr= GetArray(row, cols, -10, 10);
PrintArray(arr);



// создание двумерного массива
double[,] GetArray(int m, int n, int minValue, int maxValue) 

{

    double [,] array = new double [m, n];
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

void PrintArray(double[,] array)
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

