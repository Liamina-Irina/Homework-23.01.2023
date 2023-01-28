// Задача 52. Задайте двумерный массив 
// из целых чисел. 
// Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое 
// каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array);

double[] arrayAverage = AverageInColumns(array, 5, 5);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arrayAverage);
Console.WriteLine(".");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

double[] AverageInColumns(int[,] matrix, int columns, int rows)
{
    double[] averageInColumns = new double[columns];
    for (int i = 0; i < averageInColumns.Length; i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        averageInColumns[i] = Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(rows), 2);
        }
    return averageInColumns;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
}