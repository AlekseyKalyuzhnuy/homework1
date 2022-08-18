int[] GetBinaryArray(int size)
{
  int [] arr = new int [size];
  for (int i=0; i<size; i++)
  {
  arr[i] = new Random().Next(100);
  }

  return arr;
}

int[] array = GetBinaryArray(8);

Console.WriteLine("Массив из 8 элементов :");
Console.WriteLine($"[{string.Join(",",array) }]");

// for (int i =0; i< array.Length; i++)
//{
//  Console.Write(array[i]);
//}
