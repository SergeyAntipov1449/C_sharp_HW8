// Задача 60. Сформируйте трёхмерный массив из двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillMatrix3d(int row, int col, int lay, int rightRange, int leftRange)
{
    var rand = new Random();
    int[,,] matrix3d = new int[row, col, lay];
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(1); k++)
            {
                matrix3d[i, j, k] = rand.Next(rightRange, leftRange + 1);
            }
        }
    }
    return matrix3d;
}

void PrintMatrix3d(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(1); k++)
            {
                System.Console.Write($"{matrix3d[i, j, k]} ({i}, {j}, {k})" + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

int[] ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}

///////////////////////////////////////////////////////////////////////////////////////////////

int[] size = ReadInt("Введите количество строк, столбцов и слоёв через запятую:");
int[] range = ReadInt("Введите границы диапозона значений через запятую:");
System.Console.WriteLine();
int[,,] matrix3d = FillMatrix3d(size[0], size[1], size[2], range[0], range[1]);
PrintMatrix3d(matrix3d);