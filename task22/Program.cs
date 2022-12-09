Console.Write("Введите число N: ");
int n=Convert.ToInt32(Console.ReadLine());
int index=1;
while(index<=n)
{
    Console.Write(Math.Pow(index,2)+" ");
    index++;
}