Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100;
int c = a % 10;
Console.WriteLine($"{b}{c}");