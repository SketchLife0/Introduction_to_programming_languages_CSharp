Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num > 999) num = num / 10;
if (num < 100) Console.Write("Третьего числа нет.");
else {num = num % 10;
     Console.Write(num);
}