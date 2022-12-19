int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}


int [,,] SetArray3DRandom (int row, int line, int column)
{
    int start = 10;
    int [] number = new int [90];
    for (int i = 0; i < 90; i++)
    {
        number [i] = start++;
    }

    for (int i = 0; i < 90; i++)
    {
        int idx = new Random ().Next (0, 90);
        int tempNmr = number [idx];
        number [idx] = number [i];
        number [i] = tempNmr;
    }

    int nbrIdx = 0;
    int [,,] numArr3D = new int [row, line, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < line; j++)
        {
            for (int k = 0; k < column; k++)
            {
                numArr3D [i, j, k] = number [nbrIdx++];
            }
        }
    }
    return numArr3D;
}

void PrintArray3D (int [,,] array3D) 
{
    for (int i = 0; i < array3D.GetLength (0); i++)
    {
        for (int j = 0; j < array3D.GetLength (1); j++)
        {
            for (int k = 0; k < array3D.GetLength (2); k++)
            {
                Console.Write ($"{array3D [i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine ();
        }
        Console.WriteLine ();
    }
}

int k = InputNum ("Количество рядов массива: ");
int m = InputNum ("Количество строк массива: ");
int n = InputNum ("Количество столбцов массива: ");
Console.WriteLine ();

if (k*m*n > 90)
{
    Console.WriteLine ("Размерность массива превышает допустимую, возможны повторения чисел!");
    return;
}

int [,,] array3D = SetArray3DRandom (k, m, n);

Console.WriteLine ($"Трехмерный массив с индексами элементов:");
PrintArray3D (array3D);