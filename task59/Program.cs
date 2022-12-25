// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


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
    Console.WriteLine();
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

(int, int) findMinIndex(int[,] matr)
{
    int min = matr[0, 0];
    int mini = 0;
    int minj = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
                mini = i;
                minj = j;
            }

        }
    }
    return (mini, minj);
}

int[,] DeleteMinRowsandColumns(int[,] matrix)
{
    int rowsOffset=0;
    int columnsoffset=0;
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    (int mini, int minj) = findMinIndex(matrix);
    for (int i = 0; i < result.GetLength(0); i++)
    {
        columnsoffset=0;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if(i==mini)
            {
             rowsOffset=1;
            }
            if(j==minj)
            {
                columnsoffset=1;
            }
            result[i,j]=matrix[i+rowsOffset,j+columnsoffset];
            
        }
    }
    return result;
}

int rows = ReadInt("Введите число строк: ");
int columns = ReadInt("Введите число столбцов: ");
int[,] matrix = fillArray(rows, columns, 0, 9);
PrintArray(matrix);
(int mini, int minj) = findMinIndex(matrix);
int[,] result=DeleteMinRowsandColumns(matrix);
PrintArray(result);