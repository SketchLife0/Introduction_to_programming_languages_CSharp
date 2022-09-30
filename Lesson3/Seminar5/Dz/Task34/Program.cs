// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
for (int i = 0; i < a; i++) array[i] = new Random().Next(100, 1000);
int result = 0;
for (int i = 0; i < a; i++) if (array[i] % 2 == 0) result += 1;
Console.WriteLine(String.Join(",", array));
Console.WriteLine(result);
