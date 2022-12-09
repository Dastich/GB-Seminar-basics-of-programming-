int[] array = new int[10];

void FillArray(int[] mass)
{
    int lenght = mass.Length;
    for (int i = 0; i < lenght; i++)
    {
        mass[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] mass)
{
    int lenght = mass.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine(mass[i]);
    }

}

void ReturnArray(int [] mass)
{
    int lenght = mass.Length;
    int c = 0;
    for(int i=0,l=lenght-1;i<l; i++,l--)
    {
        c=mass[i];
        mass[i]=mass[l];
        mass[l]=c;
        
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine("Ниже будет развернутый массив");
ReturnArray(array);
PrintArray(array);
