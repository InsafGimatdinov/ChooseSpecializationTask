/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которых меньше либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения программы. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Clear();

void ShowStringArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"\"{stringArray[i]}\" ");
        if (i == stringArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
} 

int FindStringsWithLessOrEqual3(string[] stringArray)
{
    int countOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            countOfStrings++;
        }
    }
    return countOfStrings;
}

string[] FillArrayWithLessOrEqual3(string[] stringArray, int sizeNewStringArray)
{
    string[] newStringArray = new string[sizeNewStringArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}

string[] stringArray = { "kazan", "ufa", "moscow", "sochi", "ula", "123" };
ShowStringArray(stringArray);
int sizeNewStringArray = FindStringsWithLessOrEqual3(stringArray);
string[] newStringArray = FillArrayWithLessOrEqual3(stringArray, sizeNewStringArray);
Console.Write(" => ");
ShowStringArray(newStringArray);
