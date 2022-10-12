// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    WriteLine();
}

void MatrixMultiplication(int[,] matrixA, int[,] matrixB, int[,] resultMatrix){
    for (int i = 0; i < resultMatrix.GetLength(0); i++) {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) {
            for (int k = 0; k < resultMatrix.GetLength(1); k++){
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
}


Write("Введите размеры матрицы A ");
string[] inputSizeArrayA = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
Write("Введите размеры матрицы B ");
string[] inputSizeArrayB = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
if (inputSizeArrayA[1] != inputSizeArrayB[0]){
    WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
    return;
}
int[,] workingArray1 = CreateArrayTwodimensional(inputSizeArrayA);
int[,] workingArray2 = CreateArrayTwodimensional(inputSizeArrayB);
PrintTwodimensionalArray(workingArray1);
PrintTwodimensionalArray(workingArray2);
int[,] resultArray = new int [workingArray1.GetLength(0), workingArray2.GetLength(1)];
MatrixMultiplication(workingArray1, workingArray2, resultArray);
PrintTwodimensionalArray(resultArray);
