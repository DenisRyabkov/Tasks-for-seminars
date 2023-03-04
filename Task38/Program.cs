// задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double GetMaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

double GetMinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}

double GetDifferensNumber(double min, double max)
{
    double diff = max - min;
   
    return diff;
}

double[] array = CreateArrayRndDouble(5, 1, 5);
PrintArrayDouble(array);
Console.WriteLine();

double getMaxNumber = GetMaxNumber(array);
Console.WriteLine($"максимальное число = {Math.Round(getMaxNumber,2)}");

double getMinNumber = GetMinNumber(array);
Console.WriteLine($"минимальное число = {Math.Round(getMinNumber,2)}");

//double getDifferensNumber = GetDifferensNumber(array);
//Console.WriteLine($"Разница = {Math.Round(getDifferensNumber,2)}");
