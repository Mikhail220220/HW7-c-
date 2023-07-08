int [,] NewArray ()
{
    Console.WriteLine("Enter 1 number:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 2 number:");
    int number2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter min:");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max:");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] Array = new int [number1, number2];

    for (int i = 0; i < number1; i++ )
    {
        for (int j = 0; j < number2; j++)
        {
            Array [i,j] = new Random().Next(min, max + 1);
        }
    }
    return Array;
}
void PrintArray (int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j =0; j < array2d.GetLength(1); j++)
        {
            Console.Write ( array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] New2dArray = NewArray();
PrintArray (New2dArray);
