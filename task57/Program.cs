// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] fillArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

int findMax(int[,] matr)
{
    int max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (max < matr[i, j])
            {
                max = matr[i, j];
            }

        }
    }
    return max;
}

int findMin(int[,] matr)
{
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
            }

        }
    }
    return min;
}

void ChastotniySlovar(int[,] matr)
{ int count=0;
  int min=findMin(matr);
  int max=findMax(matr);
  for(int i=min;i<=max;i++)
  {
    count=0;
    for(int j=0;j<matr.GetLength(0);j++)
    {
        for(int k=0;k<matr.GetLength(1);k++)
        {
            if(matr[j,k]==i)
            {
                count++;
            }
        }
    }
    if(count!=0)
    {
    Console.WriteLine($"{i} встречается {count} раз");
    }
  }
}

int rows = ReadInt("Введите число строк: ");
int columns = ReadInt("Введите число столбцов: ");
int[,] matrix = fillArray(rows, columns, 0, 9);
PrintArray(matrix);
ChastotniySlovar(matrix);
