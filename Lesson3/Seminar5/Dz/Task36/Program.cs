// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
void SumOdd(int num){
    int[] array = new int[num];
    for (int i = 0; i < num; i++) array[i] = new Random().Next(-100, 101);
    int result = 0;
    for (int i = 0; i < num; i++) if (i % 2 == 0) result += array[i];
    // Я же так понимаю что "нечётные позиции" имеются ввиду позиции здорового человека, что считает с 1?
    // если нет то (i % 2 != 0)
    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine(result);
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
SumOdd(a);
