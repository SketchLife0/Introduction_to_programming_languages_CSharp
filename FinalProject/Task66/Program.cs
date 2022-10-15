// В решении задач ОБЯЗАТЕЛЬНОЕ использование рекурсии!
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Recalculation(int start, int exit){ 
    return start < exit ? start + Recalculation(++start, exit) : start;
}

Console.Write("Введите число начала: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число конца: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(Recalculation(a, b));
