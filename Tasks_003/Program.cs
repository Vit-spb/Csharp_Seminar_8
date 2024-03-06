using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("It is impossible to multiply.");
        }
        else
        {
            int[,] result = MatrixMultiplication(matrixA, matrixB);
            PrintMatrix(result);
        }
       }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже

    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
            result[i, j] = sum;
            }
        }
return result;
    }
using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("It is impossible to multiply.");
        }
        else
        {
            int[,] result = MatrixMultiplication(matrixA, matrixB);
            PrintMatrix(result);
        }
       }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже

    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
            result[i, j] = sum;
            }
        }
return result;
    }

void PrintMatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) // строчки
{
for (int j = 0; j < matr.GetLength(1); j++) // столбцы
{
Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
}
Console.WriteLine();
}
}

void ChangeRows(int[,] matr)
{
int indexLastRow = matr.GetLength(0) - 1; // Индекс посл. стр
// 1 2 3
// ..........
// 4 5 6
for (int i = 0; i < matr.GetLength(1); i++)
{
int temp = matr[0, i]; // temp = matr[0,0]; temp = 1
matr[0, i] = matr[indexLastRow, i]; // matr[0,0] = 4
// 4 2 3
// ..........
// 4 5 6
matr[indexLastRow, i] = temp; // temp = 1
// 4 2 3
// ..........
// 1 5 6

}
}

int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine("Результат: ");
ChangeRows(array2D);
PrintMatrix(array2D);