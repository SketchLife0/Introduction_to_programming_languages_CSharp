// Написать программу используя метод что будет получать на вход число и выдавать разрядность этого числа

int NumberOfDigits(int num)
{
    int result = 1;
    while (num > 9)
    {
        num /= 10;
        result++;
    }
    return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberOfDigits(a));
