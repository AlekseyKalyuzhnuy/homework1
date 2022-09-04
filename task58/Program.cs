// Задача 58 Задать две маторицы
// посчитать проихведение двух матриц


Console.Clear();

Console.WriteLine("Введите колиечство строк массива: ");
int row= int.Parse(Console.ReadLine());
Console.WriteLine("Введите колиечство столбцов массива: ");
int cols= int.Parse(Console.ReadLine());

int[,] arr= GetArray(row, cols, 1, 9);
PrintArray(arr);
Console.WriteLine();
int[,] ar=GetArray(row,cols,1,9);
PrintArray(ar);
Console.WriteLine();
int[,] res=multiplyArray(arr,ar);
PrintArray(res);




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
//  метод перемножения двух матриц
 int [,] multiplyArray(int[,] array1, int[,] array2)
 {
    int [,]resultArray= new int[array1.GetLength(0),array1.GetLength(1)] ;
    for(int i=0; i<resultArray.GetLength(0); i++)
    {
      for(int j=0; j<resultArray.GetLength(1); j++)
      {
        int sum=0;
        for (int k=0; k<array1.GetLength(1);k++)
        {
            sum+=array1[i,k]*array2[k,j];
        }
        resultArray[i,j]=sum;
      }

    }
    return resultArray;
 }


