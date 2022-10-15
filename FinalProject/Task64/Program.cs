// В решении задач ОБЯЗАТЕЛЬНОЕ использование рекурсии!
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Сountdown(int a){
    return a > 1 ? $"{a} {Сountdown(a-1)}" : a.ToString();
}


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(Сountdown(a));