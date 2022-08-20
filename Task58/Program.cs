/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */
Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];
int[,] arrayMulti = new int[m, n];


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Multiplicate(int[,] matrMulti)

{
    for (int i = 0; i < matrMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrMulti.GetLength(1); j++)
        {
            matrMulti[i, j] = array1[i, j] * array2[i, j];
        }
    }
}

FillArray(array1);
FillArray(array2);
Console.WriteLine("Выводим 2 массива случайных чисел");
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Multiplicate(arrayMulti);
Console.WriteLine();
Console.WriteLine("Массив из перемноженных элементов первых двух массивов:");
PrintArray(arrayMulti);

