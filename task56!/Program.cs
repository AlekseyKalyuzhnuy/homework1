// Задача 56 Задать двумерный массив прямоугольный
// Посчитать строку с наименьшей суммой элементов

Console.Clear();

Console.WriteLine("Введите колиечство строк массива: ");
int row= int.Parse(Console.ReadLine());
Console.WriteLine("Введите колиечство столбцов массива: ");
int cols= int.Parse(Console.ReadLine());

int[,] arr= GetArray(row, cols, 1, 9);
if (row==cols)
{
   Console.WriteLine("массив не является прямоугольным");
}
else
{
PrintArray(arr);
Console.WriteLine();
SumArray(arr);
}



// создание двумерного массива
int[,] GetArray(int m, int n,int minValue, int maxValue) 

{
    int[,] array = new int [m, n];
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

// считаем сумму в строках

void SumArray(int[,] array)
{  
    int summin =0;
    int sum1=0;
    
     for(int j=0; j<array.GetLength(1); j++) 
    {  
    summin=summin+array[0,j];
    }
    // считаем сумма первой строки
    

    for (int i=1; i<array.GetLength(0); i++)
    {
     sum1=0;
     for(int j=0; j<array.GetLength(1); j++)
       {  
        sum1=sum1+array[i,j];

       } 
      // считаем сумму остальных строк   
    }
    if  (sum1<summin)   
    summin=sum1;
    Console.WriteLine(summin);
}
