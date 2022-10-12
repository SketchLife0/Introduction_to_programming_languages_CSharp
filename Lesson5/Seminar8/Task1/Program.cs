// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
using static System.Console;

int[,] CreateArrayTwodimensional(string[] arr){
    int[,] result = new int[Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1])];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            result[i, j] = new Random().Next(0, 11);
        }
    }
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            Write($"{result[i, j]}\t");
        }
        WriteLine();
    }
    return result;
}

    

Dictionary<int, int> FrequencyDictionaryElements(int[,] arr){
    var nums = new Dictionary<int, int>();
    foreach (var item in arr){
        if(!nums.ContainsKey(item)) nums.Add(item, 1);
        else nums[item] += 1;
    }
    return nums;
}


Write("Введите размеры массива ");
string[] inputSizeArray = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[,] workingArray = CreateArrayTwodimensional(inputSizeArray);
var dict = FrequencyDictionaryElements(workingArray);
Write("Какое число мы ищем? ");
int a = Convert.ToInt32(ReadLine());
WriteLine($"В массиве {dict[a]} чисел {a}");
