// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 50);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
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

void ChangeHighAndLowRows(int[,] matrix)
{
    int temp=0;
    for(int i=0;i<matrix.GetLength(1);i++)
    {
        temp=matrix[0,i];
        matrix[0,i]=matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i]=temp;
    }
}

const int ROWS=5;
const int COLUMNS=6;
int[,] matrix=FillArray(ROWS,COLUMNS);
PrintMatrix(matrix);
Console.WriteLine();
ChangeHighAndLowRows(matrix);
PrintMatrix(matrix);
