/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[] array1 = new int[m];


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
void PrintArray1(int[] matr1)
{
    for (int i = 0; i < matr1.Length; i++)
    {

        Console.Write($"{matr1[i]} ");


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
void SummaVStroke(int[,] matr, int[] matr1)
{
    int SumRaw = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            SumRaw = SumRaw + matr[i, j];
        }
        Console.WriteLine("Сумма в стороке № " + i + "= " + SumRaw);
        matr1[i] = SumRaw;
    }
}
void FindMaxMin(int[] matr1)
{
    int lenght = matr1.Length;
    int index = 0;
    int max = matr1[0];
    int min = matr1[0];
    int indmax = 0;
    int indmin = 0;
    while (index < lenght)
    {
        if (matr1[index] > max)
        {
            max = matr1[index];
            indmax = index;
        }
        if (matr1[index] < min)
        {
            min = matr1[index];
            indmin = index;
        }
        index++;
    }

    Console.WriteLine($"Строка с минимальной суммой №: {indmin}");


}

FillArray(array);
Console.WriteLine("Выводим массив случайных чисел");
PrintArray(array);
SummaVStroke(array, array1);
Console.WriteLine();
PrintArray1(array1);
FindMaxMin(array1);

