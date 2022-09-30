// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void EvenNumbersInArray (int num){
    int[] array = new int[num];
    for (int i = 0; i < num; i++) array[i] = new Random().Next(100, 1000);
    int result = 0;
    for (int i = 0; i < num; i++) if (array[i] % 2 == 0) result += 1;
    Console.WriteLine(String.Join(",", array));
    Console.WriteLine(result);
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
EvenNumbersInArray(a);
