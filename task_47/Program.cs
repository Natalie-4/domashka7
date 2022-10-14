// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillInTheMembers (double [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row,column] = Math.Round(new Random().NextDouble()*10,2);
            Console.Write(array[row,column] + " \t");
        }
        Console.WriteLine();
    }
}

double [,] massive = new double[m,n];
FillInTheMembers(massive);