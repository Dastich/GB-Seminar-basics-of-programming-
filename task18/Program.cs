Console.Write("Введите номер координатной четверти:");
int number=Convert.ToInt32(Console.ReadLine());

while(number>4||number<0)
{
    Console.WriteLine("Введеный номер неккоректный, введите его повторно: ");
     number=Convert.ToInt32(Console.ReadLine());
}
if(number==1)
{
    Console.WriteLine("Допустимые значения:x>0,y>0");
}
if(number==2)
{
    Console.WriteLine("Допустимые значения:x<0,y>0");
}

if(number==3)
{
    Console.WriteLine("Допустимые значения:x<0,y<0");
}

if(number==4)
{
    Console.WriteLine("Допустимые значения:x>0,y<0");
}

