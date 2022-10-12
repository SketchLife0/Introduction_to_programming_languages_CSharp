// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;

int[,,] CreateArrayThreedimensional(string[] arr) {
    int[,,] result = new int[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2])];
    var banNumbers = new List <int>{};
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                do{
                    result[i, j, k] = new Random().Next(0, 101);
                }while(banNumbers.IndexOf(result[i, j, k]) != -1);
                banNumbers.Add(result[i, j, k]);
            }
        }
    }
    return result;
}

void PrintThreedimensionalArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            WriteLine();
        }
    }
    WriteLine();
}

Write("Введите размеры трёхмерного массива: ");
string[] inputSizeArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[,,] workingArray = CreateArrayThreedimensional(inputSizeArray);
PrintThreedimensionalArray(workingArray);
