//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;

int[,] CreateArrayTwodimensional(string[] arr) {
    int[,] result = new int[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])];
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}

void PrintTwodimensionalArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Write($"{array[i, j]}\t");
        }
        WriteLine();
    }
}

string SearchSmallSum(int [,] arr) {
    int sum = 0;
    int [] workArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i,j];
        workArray[i] = sum;
        sum = 0;
    }
    int minSum = workArray[0];
    int numberLine = 0;
    for (int i = 1; i < workArray.Length; i++) {
        if(workArray[i] < minSum) {
            minSum = workArray[i];
            numberLine = i;
        }
    }
    return $"Строка с наименьшей суммой элементов: {numberLine} сумма равна {minSum}";
}


string[] inputSizeArray = new string [2];
while (inputSizeArray[0] == inputSizeArray[1]) {
    Write("Введите размеры ПРЯМОУГОЛЬНОГО массива ");
    inputSizeArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
}
int[,] workingArray = CreateArrayTwodimensional(inputSizeArray);
PrintTwodimensionalArray(workingArray);
WriteLine(SearchSmallSum(workingArray));
