// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

string[] arr = { "Hello", "2", "world", ":-)" };
PrintArray(arr);
Console.Write(" -> ");

string[] newArr = findStringWithThreeCharForArray(arr);
PrintArray(newArr);

string[] findStringWithThreeCharForArray(string[] arr)
{
    string[] newArr = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr = incArr(newArr);
            newArr[newArr.Length - 1] = arr[i];
        }
    }
    return newArr;
}

string[] incArr(string[] arr)
{
    string[] newArr = new string[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}