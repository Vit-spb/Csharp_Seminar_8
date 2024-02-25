// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// // // Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// // // minValue - мин. число для рандома, maxValue - макс. число для рандома

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
{
// i, j, k, m
for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
{
matrix[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return matrix;
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