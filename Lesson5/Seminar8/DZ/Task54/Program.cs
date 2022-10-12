// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;

int[,] CreateArrayTwodimensional(string[] arr){
    int[,] result = new int[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}

void PrintTwodimensionalArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}

void ArraySorting(int[,] arr){ // Сортировка строк пузырьком по убыванию
    int buffer = 0; 
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int k = 0; k < arr.GetLength(1); k++){ // сколько элементов в строке столько и проходов
            for (int j = 1; j < arr.GetLength(1); j++){
                if (arr[i,j] > arr[i,j-1]){
                    buffer = arr[i,j];
                    arr[i,j] = arr[i,j-1];
                    arr[i,j-1] = buffer;
                }
            }
        }
    }
}


Write("Введите размеры массива ");
string[] inputSizeArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[,] workingArray = CreateArrayTwodimensional(inputSizeArray);
PrintTwodimensionalArray(workingArray);
WriteLine();
ArraySorting(workingArray);
PrintTwodimensionalArray(workingArray);
