// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void ArraySignChange(int[] array)
{
    for (int i=0; i<array.Length;i++)
    {
        array[i]*=-1;
    }
}

const int LENGTH=10;
const int LEFTRANGE=-10;
const int RIGHTRANGE=10;
int [] massive =GetRandomArray(LENGTH,LEFTRANGE,RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
ArraySignChange(massive);
Console.WriteLine($"{string.Join(", ", massive)}");

