// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] GetRandomArray(int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

(int, int) SumPositiveAndNegative(int[] array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            SumPositive += array[i];
        }
        else
        {
            SumNegative += array[i];
        }
    }
    return (SumPositive, SumNegative);
}
const int LENGHT = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int[] massive = GetRandomArray(LENGHT, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int sumP, int sumN)= SumPositiveAndNegative(massive);
Console.WriteLine($"Сумма положительных элементов равна {sumP}, отрицательных равна {sumN}");