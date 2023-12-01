int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,,] CreateArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] FillArrayRandom(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
    return array;
}

int[,,] newArr3D = CreateArray(Prompt("Input A: "), Prompt("Input B: "), Prompt("Input C: "));
Console.WriteLine();
FillArrayRandom(newArr3D);
PrintArray(newArr3D);