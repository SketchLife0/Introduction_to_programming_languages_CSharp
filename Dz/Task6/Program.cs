Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0){
    Console.Write($"{a} - чётное число ");
}
else{
    Console.Write($"{a} - нечётное число ");
}