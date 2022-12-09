// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetmultiplicationOfNumber(int number)
{
    int res=1;
    for(int i=1;i<=number;i++)
    {
        res=res*i;
    }
    return res;
}

int number=ReadInt("Введите число: ");
int result= GetmultiplicationOfNumber(number);
Console.WriteLine($"Сумма произведения числе равна {result}");