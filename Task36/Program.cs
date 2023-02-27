// задайте одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях
// [3,7,23,12] -> 19 ???? должно быть вроде как 22

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
       for (int i = 0; i < arr.Length; i++)
    {
        if(i< arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    } 
    Console.Write("]");
}

int GetSumOddNumber (int[] arr)
{
    int sumOdd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if(i % 2 != 0) sumOdd = sumOdd+arr[i]; 
    }
    return sumOdd;
}

int [] array = CreateArrayRndInt(4, 100, 1000);
PrintArray(array);
Console.WriteLine();

int getSumOddNumber = GetSumOddNumber(array);

Console.WriteLine($"сумма чисел нечетных позиций = {getSumOddNumber}");
