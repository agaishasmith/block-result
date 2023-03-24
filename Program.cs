/* написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 или равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/

Console.Clear();

int size = 12;
int[] array = GetArray(size);
PrintArray(array);

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(0, 10);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

int[] NewArray(int[] array)
