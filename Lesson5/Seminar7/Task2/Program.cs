// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4

double[,] numArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
for (int i = 1; i < numArray.GetLength(0); i++)
{
    if ((i + 1) % 2 == 0)
    {
        for (int j = 1; j < numArray.GetLength(1); j++)
        {
            if ((j + 1) % 2 == 0) numArray[i, j] = Math.Pow(numArray[i, j], 2);
        }
    }
}
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        Console.Write($"{numArray[i, j]} ");
    }
    Console.WriteLine();
}

