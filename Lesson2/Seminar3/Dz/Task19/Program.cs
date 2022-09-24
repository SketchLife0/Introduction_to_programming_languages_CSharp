Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num > 99999 | num < 10000)
{
    Console.Write("Дурачок, введи нормально: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int num2 = num / 1000 % 10;
int num4 = num / 10 % 10;
if (num / 10000 == num % 10 && num2 == num4) Console.WriteLine("Кайф");
else Console.WriteLine("Не кайф");
