// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string digit=String.Empty;

int count=0;
while(n!=0)
{
    n/=2;
    count++;
}
Console.WriteLine(count);
int[] array=new int[count];
for(int i=0;i<count;i++)
{
    
}
