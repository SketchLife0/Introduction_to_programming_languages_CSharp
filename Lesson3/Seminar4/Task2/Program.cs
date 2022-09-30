// Первый метод создаёт бинарный массив по полученной длине
int [] ArrayCreation(int lenght)
{
    int[] list = new int[lenght];
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        list[i] = new Random().Next(0, 2);
        if (i != lenght - 1) Console.Write($"{list[i]}, ");
        else Console.WriteLine($"{list[i]}]");
    }
    return list;
}

// Второй метод получает на вход массив и число для поиска а после выдаёт максимальную последовательность одного числа в массиве
void GetNumberCount(int [] array, int num){
    int result = 0;
    int max = 0;
    for (int i=0; i < array.Length; i++){
        if (array[i] == num) {
            result++;
            if (result > max){
                max = result;
            }
        }
        else result = 0;
    }
    Console.Write(max);
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска: ");
int b = Convert.ToInt32(Console.ReadLine());
GetNumberCount(ArrayCreation(a), b);
