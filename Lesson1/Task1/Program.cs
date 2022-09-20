using static System.Console;
Write("Введи первое число: ");
int a = Convert.ToInt32(ReadLine());
Write("Введи второе число: ");
int b = Convert.ToInt32(ReadLine());
int c = b ^ 2;
WriteLine(c);
if (b * b == a){
    WriteLine($"Число {a} является квадратом числа {b}");
}
else{
    WriteLine($"Число {a} не является квадратом числа {b}");
}