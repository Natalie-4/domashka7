/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */
Console.WriteLine("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void FillInArray(int [,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row,column] = new Random().Next(0,11);
            Console.Write(array[row,column] + " \t");
        }
        Console.WriteLine();
    }
}

int [,] Massive = new int[row,column];
FillInArray(Massive);
Console.WriteLine();


double [] Average = new double[Massive.GetLength(1)];
  
for (int j = 0; j < Massive.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Massive.GetLength(0); i++)
    {
    sum = sum + Massive[i,j];
    Average[j] = sum / (Massive.GetLength(0));  
    }
    
    Console.Write($" {Average[j]}");
}

//Console.Write($" {Average[j]}"); 