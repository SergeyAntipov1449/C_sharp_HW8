// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int LowSumRow(int[,] matrix)
{
    int rowNum = 0;
    int rowSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        rowSum += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSum += matrix[i, j];
        }
        if (tempSum < rowSum)
        {
            rowNum = i;
            rowSum = tempSum;
        }

    }
    return rowNum;
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
System.Console.WriteLine($"Строка {LowSumRow(matrix)} содержит элементы дающие наименушую сумму");