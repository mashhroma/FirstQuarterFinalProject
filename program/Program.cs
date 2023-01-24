// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями. Лучше обойтись исключительно массивами.

string[] CreateArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray (string[] collection)
{
    foreach (var item in collection) Console.Write (item + " ");
}

string[] GetSomeSymbolsArray (string[] collection, int lengthItem)
{
    string text = String.Empty;
    int size = 0;
    string[] newArray = new string[size];
    foreach (var item in collection)
    {
        if (item.Length <= 3) 
        {
            text += $"{item} ";
            size++;
        }
    }
    return newArray = text.Split(' ', size);
}

string[] words = CreateArray(5);
PrintArray(words);

Console.WriteLine();

string[] threeSymbolsArr = GetSomeSymbolsArray(words, 3);
PrintArray(threeSymbolsArr);