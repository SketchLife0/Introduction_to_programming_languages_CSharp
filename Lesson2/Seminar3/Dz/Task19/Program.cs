// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num > 99999 | num < 10000)
// {
//     Console.Write("Дурачок, введи нормально: ");
//     num = Convert.ToInt32(Console.ReadLine());
// }
// int num2 = num / 1000 % 10;
// int num4 = num / 10 % 10;
// if (num / 10000 == num % 10 && num2 == num4) Console.WriteLine("Кайф");
// else Console.WriteLine("Не кайф");

// Второй вариант для любого числа
Console.Write("Введите число: ");
string a = Console.ReadLine()!;
int num = Convert.ToInt32(a);
string result = "";
while (num != 0)
{
    result += Convert.ToString(num % 10);
    num/=10;
}
if (result == a) Console.WriteLine("Кайф");
else Console.WriteLine("Не кайф");
