/* написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 или равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/
Console.Clear();
string[] array1 = new string[] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];

PrintArray(array1);
FindElement(array1, array2);
PrintArray(array2);

void FindElement(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
