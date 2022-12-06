Console.Write("Введите координаты точки по X: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки по Y: ");
int y=Convert.ToInt32(Console.ReadLine());

if(x>0&&y>0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
if(x<0&&y>0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
if(x<0&&y<0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
if(x>0&&y<0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}