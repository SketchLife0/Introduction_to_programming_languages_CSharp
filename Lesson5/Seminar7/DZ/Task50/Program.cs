// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

void SearchElement(int[,] arr, int i, int j) { WriteLine(arr[i, j]); }

void PrintTwodimensionalArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}


Write("Введите размеры массива ");
string[] inputSizeArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[,] workingArray = CreateArrayTwodimensional(inputSizeArray);
PrintTwodimensionalArray(workingArray);

Write("Какой индекс найти? ");
string[] indexArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int indexA = 0;
int indexB = Convert.ToInt32(indexArray[0]);
if (indexArray.Length > 1) indexA = Convert.ToInt32(indexArray[1]);
if ( indexA > workingArray.GetLength(0) - 1 || indexB > workingArray.GetLength(1) - 1) WriteLine("Такого элемента нет");
else SearchElement(workingArray, indexA, indexB);
