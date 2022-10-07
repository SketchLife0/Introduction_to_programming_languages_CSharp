// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
int[,] CreateArray(string[] arr) { return new int[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])]; }

void PrintNewArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размеры массива ");
string[] a = Console.ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[,] result = CreateArray(a);
PrintNewArray(result);
