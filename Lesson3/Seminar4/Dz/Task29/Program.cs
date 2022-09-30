// Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
void ArrayCreation(int lenght)
{
    int[] list = new int[lenght];
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        list[i] = new Random().Next(1, 101);
        if (i != lenght - 1) Console.Write($"{list[i]}, ");
        else Console.WriteLine($"{list[i]}]");
    }
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
ArrayCreation(a);
