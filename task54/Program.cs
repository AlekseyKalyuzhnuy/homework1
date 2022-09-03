// задача 54 Задать двумерный массив
// упорядочить по убыванию элементы каждой строки массива

Console.Clear();

Console.WriteLine("Введите колиечство строк массива: ");
int row= int.Parse(Console.ReadLine());
Console.WriteLine("Введите колиечство столбцов массива: ");
int cols= int.Parse(Console.ReadLine());

int[,] arr= GetArray(row, cols, 1, 9);
PrintArray(arr);
Console.WriteLine();

 SelectionSort(arr); // сортируем



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

// сортируем массив 




void SelectionSort(int[,] array)
{   
    for ( int i=0; i<array.GetLength(0); i++)
    {
      for(int j=0; j<array.GetLength(1); j++)
       {
         for(int k=0; k<array.GetLength(1); k++)
         {
           if(array[i,j]<=array [i,k]) continue;
           int tmp = array [i,j];
           array[i,j]=array[i,k];
           array[i,k]=tmp;
         }
       }
    }
    PrintArray(array);
}

