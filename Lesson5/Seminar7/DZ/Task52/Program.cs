// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;

int[,] CreateArrayTwodimensional(string[] arr){
    int[,] a = new int[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])];
    for (int i = 0; i < a.GetLength(0); i++){
        for (int j = 0; j < a.GetLength(1); j++){
            a[i, j] = new Random().Next(0, 11);
        }
    }
    return a;
}

void PrintTwodimensionalArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}

void PrintArithmeticMeanColumn(int[,] a){
    double result = 0;
    string output = "Среднее арифметическое каждого столбца: ";
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            result += a[i,j];
        }
        result /= a.GetLength(0);
        output += $"{Convert.ToString(result)}; ";
        result = 0;
    }
    Console.WriteLine(output);
}


Write("Введите размеры массива ");
string[] inputSizeArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[,] workingArray = CreateArrayTwodimensional(inputSizeArray);
PrintTwodimensionalArray(workingArray);
PrintArithmeticMeanColumn(workingArray);
