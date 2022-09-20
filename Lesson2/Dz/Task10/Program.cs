Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a % 100;
result = result / 10;
Console.WriteLine(result);