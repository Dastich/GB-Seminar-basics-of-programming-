// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

int[] MultiplicationOfArray(int[] array)
{
    int[] result = new int[array.Length / 2+array.Length%2];
    for (int i = 0; i < result.Length; i++)
    {
        if(i==result.Length-1-i)
        {
            result[i]=array[i];
        }
        else
        {
        result[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return result;
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine($"{string.Join(", ", array)}");
int[] array2 = MultiplicationOfArray(array);
Console.WriteLine($"{string.Join(", ", array2)}");