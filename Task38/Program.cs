// задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] CreateArrayRndDouble(int size, int min, int max)
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
        if(i< arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    } 
    Console.Write("]");
}

double GetMinNumber (double[] arr)
{
    double min = 0;
    for (int i = 0; i < arr.Length; i++)
{
	if (min > i) min = i;	
}
return min;
}

double GetMaxNumber (double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
{
	if (max < i) max = i;
}
return max;
}

double GetResultNumber (double[] arr)
{
{
    double result = 0;
    result = max - min;
}
return result;
}

double [] array = CreateArrayRndDouble(5, 1, 5);
PrintArrayDouble(array);
Console.WriteLine();

double getMinNumber = GetMinNumber(array);
double getMaxNumber = GetMaxNumber(array);
double getResultNumber = GetResultNumber(array);
//Console.WriteLine($"минимальное число = {getMinNumber}");
//Console.WriteLine($"максимальное число = {getMaxNumber}");
Console.WriteLine($" разница чисел = {getResultNumber}");