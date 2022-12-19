int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,] SpiralArray (int side)
{
    int number = 1;
    int i = 0;
    int j = 0;
    int [,] spiralArr = new int [side, side];
    while (number <= side*side)
    {
        spiralArr [i, j] = number++;
        if (i <= j + 1 && i + j < side - 1)
            j++;
        else if (i < j && i + j >= side - 1)
            i++;
        else if (i >= j && i + j > side - 1)
            j--;
        else
            i--;
    }
    return spiralArr;
}

void PrintArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            if (array2D [i, j] < 10)
            Console.Write ($"0{array2D [i, j]} ");
            else
            Console.Write ($"{array2D [i, j]} ");
        }
        Console.WriteLine ();
    }
}

int n = InputNum ("Задайте сторону n массива nxn: ");

int [,] array = SpiralArray (n);

Console.WriteLine ($"Спиральный массив {n}x{n} :");
PrintArray2D (array);