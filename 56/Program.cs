void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];
        }
        Console.WriteLine($"Строка {i + 1} = {summa}");
    }
}

int SumLineMatrix (int [,] matrix)
{
    int [] sumArr = new int [matrix.GetLength (0)];
    Console.Write ($"Суммы строк:");
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            sumArr [i] += matrix [i, j];
        }
        Console.Write ($" {sumArr [i]}");
    }
    Console.WriteLine ();
    int minSum = sumArr [0];
    int minLine = 1;
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        if (sumArr [i] < minSum) 
        {
            minSum = sumArr [i];
            minLine = i+1;
        }
    }
    return minLine;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);

int line = SumLineMatrix (matrix);

Console.WriteLine ($"Наименьшая сумма элементов в {line} строке");