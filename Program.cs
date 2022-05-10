// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. -->

string[] array = { "Hello", "2", "mouse", "ok", "-2" };

int count = 0;
for (int index = 0; index < array.Length; index++)
{
    if (array[index].Length < 4)
    {
        count++;
    }
}
string[] newArray = new string[count];
int indexx = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        newArray[indexx] = array[i];
        indexx++;
    }
}
PrintArray(array);
PrintArray(newArray);
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "  |  ");
    }
    System.Console.WriteLine();
}
