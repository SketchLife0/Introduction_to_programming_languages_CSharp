// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int NumberOfDigits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberOfDigits(a));
