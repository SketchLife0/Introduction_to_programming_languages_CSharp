//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void LimitDifference(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++) array[i] = new Random().Next(1, 1000);
    int result = 0;
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (item < min) min = item;
        if (item > max) max = item;
    }
    result = max - min;
    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine(result);
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
LimitDifference(a);
