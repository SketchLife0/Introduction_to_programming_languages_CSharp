//  Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
int Exponentiation(int num, int degree = 2)
{
    int result = 1;
    while (degree > 0)
    {
        result *= num;
        degree--;
    }
    return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
string line = Console.ReadLine()!;
int numericValue;
if (int.TryParse(line, out numericValue)) 
{
    int b = Convert.ToInt32(line);
    Console.WriteLine(Exponentiation(a, b));
}
else Console.WriteLine(Exponentiation(a));

