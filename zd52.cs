int[,] GetRandomMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
       for (int j= 0; j < n; j++)
       {
         result [i, j] = new Random ().Next(minVale, maxValue + 1);
       }
    }
    return result;
}
void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength (1); j++)
      {
        Console.Write($" {array[i, j]}\t ");
      }
      Console.Writeline();
   }
}
double[] AverageInMatrix(int [,] matrix)
{
  double[] result = new double [matrix. GetLength(1)];
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    double total = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        total += matrix[j, i];
    }
    total /= matrix.GetLength(0);
    result[i] = total;
  }
  return result;
}
int[,] matr = GetRandomMatrix(m: 4, n: 5, minValue: 10, maxValue: 90);
PrintArray(matr);
double[] result = AverageInMatrix (matr);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", result)}");