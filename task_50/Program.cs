/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки: ");
int NumberOfRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int NumberOfColumn = Convert.ToInt32(Console.ReadLine());

void FillInArray(int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row,column] = new Random().Next(-1000,1001);
            Console.Write(array[row,column] + " \t");
        }
        Console.WriteLine();
    }
}

int [,] A = new int[row,column];
FillInArray(A);

if (NumberOfRow > A.GetLength(0) || NumberOfColumn > A.GetLength(1))
        Console.WriteLine("Нет такого элемента в массиве ");
else
    {
    Console.WriteLine("Элемент найден");
    Console.WriteLine($"A [{NumberOfRow}, {NumberOfColumn}] = {A[NumberOfRow-1, NumberOfColumn-1]}");
    }
