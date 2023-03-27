/* написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 или равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/
Console.Clear();
string[] array = new string[] {"hello", "2", "world", ":-)"};
string[] elements = new string[array.Length];

PrintArray(array);
FindElement(array, elements);
PrintArray(elements);

void FindElement(string[] array, string[] elements)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        elements[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{String.Join(", ", array[i])} ");
    }
    Console.WriteLine();
}

