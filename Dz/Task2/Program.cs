using static System.Console;
Write("Введи первое число: ");
int a = Convert.ToInt32(ReadLine());
Write("Введи Второе число: ");
int b = Convert.ToInt32(ReadLine());
if (a > b){
    Write($"max = {a}");
}
else{
    Write($"max = {b}");
}