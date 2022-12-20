// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
void FillArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

int[] CopyArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i];
    }
    return newarray;
}
int[] array = new int[8];
FillArray(array);
int[] newarray = CopyArray(array);
Console.WriteLine(string.Join($", ", newarray));


