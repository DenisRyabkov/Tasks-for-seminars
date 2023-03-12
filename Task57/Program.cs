// Составить частотны словарь элементов двумерного массива.
// ЧС содержит информацию о том, сколько раз встречается элемент входных данных
//
// 1 2 3 
// 4 6 1 
// 2 1 6 
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раза
// 4 встречается 1 раза
// 6 встречается 2 раза

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  //  [rows, columns] = [0,1]
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 4} ");
    } 
    Console.WriteLine();
}
}
int[] MatrixToArray(int[,] matrix)
{
    int schet=0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          array[schet] = matrix[i,j];
          schet +=1;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

void ScoreElemArray(int[] array)
{
int count = 1;
int curentNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
  if(array[i] == curentNumber) count++;
  else
  {
    Console.WriteLine($"Число {curentNumber} встречается {count} раз");
    curentNumber = array[i];
    count = 1;
  }
}
Console.Write($"Число {curentNumber} встречается {count} раз");
}


int[,] matrix = CreateMatrixRndInt(3,3,0,10);
int[] arr = MatrixToArray(matrix);

PrintMatrix(matrix);
PrintArray(arr);
Console.WriteLine();

Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();

ScoreElemArray(arr);
