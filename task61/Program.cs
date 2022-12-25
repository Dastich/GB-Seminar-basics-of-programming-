int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] tableofPascal(int n)
{
    int[,] matrix = new int[n + 2, 2 * n + 2];
    matrix[0, n] = 1;
    int j = 0;
    for (int i = 1; i < matrix.GetLength(0) - 1; i++)
    {
        j = 0;
        if (matrix[i - 1, j + 1] == 1)
        {
            matrix[i, j] = 1;
        }
        for (j = 1; j < matrix.GetLength(1) - 1; j++)
        {

            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];

        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] != 0)
            {
                Console.Write(matr[i, j]);
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int n = ReadInt("Введите число N: ");
int[,] table = tableofPascal(n);
PrintArray(table);
