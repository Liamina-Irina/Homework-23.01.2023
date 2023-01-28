// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(String.Empty);

if (rowNumber > 0 && columnNumber > 0)
{
    int[,] matrix = CreateMatrixRndInt(5, 5, 1, 10);
    PrintMatrix(matrix);
    Console.WriteLine(String.Empty);

    if (IsElementInMatrix(matrix,rowNumber, columnNumber)) Console.WriteLine($"{matrix[rowNumber - 1, columnNumber - 1]}");
    else Console.WriteLine($"такого элемента в массиве нет");
}
else Console.WriteLine($"Вы ввели некорректное значение строки или столбца");

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

bool IsElementInMatrix(int[,] matrix, int row, int column)
{
    if (row > matrix.GetLength(0) || column > matrix.GetLength(1)) return false;
    else return true;
}