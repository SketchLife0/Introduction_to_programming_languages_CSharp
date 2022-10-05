// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int NumCalculation(string strnum)
{
    string[] arNum = strnum.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
// Если убрать ',' а 9 строку изменить на double a = Convert.ToDouble(item) то можно спокойно работать и с числами с плавающей точкой
    int result = 0;
    foreach (var item in arNum)
    {
        int a = Convert.ToInt32(item);
        if (a > 0) result++;
    }
    return result;
}


Console.Write("Введите целые числа: ");
string a = Console.ReadLine()!;
Console.WriteLine(NumCalculation(a));
