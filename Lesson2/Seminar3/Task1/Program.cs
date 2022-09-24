Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1:
    {
        Console.WriteLine("X<0 Y>0");
        break;
    }
    case 2:{
        Console.WriteLine("X>0 Y>0");
        break;
    }
    case 3:{
        Console.WriteLine("X<0 Y<0");
        break;
    }
    case 4:{
        Console.WriteLine("X<0 Y<0");
        break;
    }
}