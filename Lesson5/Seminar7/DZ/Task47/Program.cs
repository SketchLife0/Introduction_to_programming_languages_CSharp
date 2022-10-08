// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleArrayTwodimensional(string[] arr) 
{ 
    double[,] a = new double[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = Math.Round(new Random().NextDouble()*(10-(-10))+(-10),2);
        }
    }
    return a; 
}

void PrintTwodimensionalArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размеры массива ");
string[] a = Console.ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
double[,] result = CreateDoubleArrayTwodimensional(a);
PrintTwodimensionalArray(result);
