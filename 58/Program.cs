int[,] firstMartrix = new int[4, 4];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[4, 4];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[4, 4];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение этих двух матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,5);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}