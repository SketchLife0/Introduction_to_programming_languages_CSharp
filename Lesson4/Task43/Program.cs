// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4, 
// y = k1 * x + b1, y = k2 * x + b2
// y = 5 * x + 2, y = 9 * x + 4

// k1 * x + b1 = k2 * x + b2
// 5 * x + 2 = 9 * x + 4

// (k1 - k2) * x = b2 - b1
// (5 - 9) * x = 4 - 2

// x = (b2 - b1) / (k1 - k2)
// x = 2 / -4 = -0.5

// y = k * x + b
// y = 5 * -0.5 + 2 = -0.5
// y = 9 * -0.5 + 4 = -0.5

void IntersectionSearch(int firstK, int firstB, int secondK, int secondB)
{
    var x = (double) (secondB - firstB) / (firstK - secondK);
    var y = (double) firstK * x + firstB;
    Console.WriteLine($"Точка пересечения двух прямых находится по координатам ({x}; {y})");
}

Console.WriteLine("Две прямые заданы формулой y = k * x + b");
Console.Write("Введите значение k для первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b для первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k для второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b для второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());
IntersectionSearch(k1, b1, k2, b2);
