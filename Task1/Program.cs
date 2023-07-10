// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void SortDecInRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] FillMatrix(int row, int col, int rightRange, int leftRange)
{
    var rand = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(rightRange, leftRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////

int[] size = ReadInt("Введите количество строк и столбцов через запятую:");
int[] range = ReadInt("Введите границы диапозона значений через запятую:");
System.Console.WriteLine();
int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);
PrintMatrix(matrix);
System.Console.WriteLine();
SortDecInRows(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);