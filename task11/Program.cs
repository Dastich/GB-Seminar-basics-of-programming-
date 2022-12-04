int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число={number}");
int first = number/100;
int third = number%10;
int result =first*10+third;
Console.WriteLine(result);