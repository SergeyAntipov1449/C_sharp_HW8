// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
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

//////////////////////////////////////////////////////////////////////////////////////////////////////

int[] size1 = ReadInt("Введите количество строк и столбцов первой матрицы через запятую:");
int[] range1 = ReadInt("Введите границы диапозона значений для первой матирцы через запятую:");
int[] size2 = ReadInt("Введите количество строк и столбцов второй матрицы через запятую:");
int[] range2 = ReadInt("Введите границы диапозона значений для второй матрицы через запятую:");
if (size1[0] != size2[1])
{
    System.Console.WriteLine("Перемножение таких матриц невозможно");
    return;
}
System.Console.WriteLine();
int[,] matrix1 = FillMatrix(size1[0], size1[1], range1[0], range1[1]);
System.Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = FillMatrix(size2[0], size2[1], range2[0], range2[1]);
System.Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
System.Console.WriteLine();
System.Console.WriteLine("Результирующая матрица:");
PrintMatrix(MatrixMult(matrix1, matrix2));
