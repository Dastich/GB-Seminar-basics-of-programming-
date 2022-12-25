// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
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


int[,] SwapRowsAndColumns(int[,] matrix)
{
    int[,] copymatrix= new int[matrix.GetLength(1),matrix.GetLength(0)];
    for(int i=0;i<matrix.GetLength(1);i++)
    {
        for(int j=0;j<matrix.GetLength(0);j++)
        {
            copymatrix[i,j]=matrix[j,i];
        }

    }
    return copymatrix;
    
}

int rows=3;
int columns=4;
int[,] matrix=FillArray(rows,columns);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrixcopy=SwapRowsAndColumns(matrix);
PrintMatrix(matrixcopy);



void FrequentMethod(int[,]arr, int leftReng = 0, int rightRange = 9)
{
    for(int D = leftReng; D <= rightRange; D++ )
    {
        int count = 0;
        for(int i = 0; i != arr.GetLength(0); i++)
        {
            for(int j = 0; j != arr.GetLength(1); j++)
            {
                if(arr[i,j] == D)
                {
                    count++;
                }
            }
            //System.Console.WriteLine();
        }
        if(count!=0)
        {
            System.Console.WriteLine($"Число {D} встречается {count} раз");
        }
    }    
}


int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

int[,] massiv = GetRandomMatrix(M, N);
PrintArray(massiv);
FrequentMethod(massiv);