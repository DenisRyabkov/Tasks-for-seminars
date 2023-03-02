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
//double getMaxNumber = GetMaxNumber();
GetMaxNumber();


//double GetMinNumber (double[] arr)
/*{
    double min = arr [0];
    minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
{
	if (min > arr [i])
    {
        min = arr [i];
        minIndex = i;
    }
}
return min;
}*/

/*double GetMaxNumber (double[] arr)
{
    double max = arr [0];
    maxIndex = 0;
    for (int i = 0; i < arr.Length; i++)
{
	if (max < arr[i])
    {
       max = arr [i];
       maxIndex = i; 
    }
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
*/
double[] array = CreateArrayRndDouble(5, 1, 5);
PrintArrayDouble(array);
Console.WriteLine();

//double getMinNumber = GetMinNumber(array);
//double getMaxNumber = GetMaxNumber(array);
//double getResultNumber = GetResultNumber(array);
//Console.WriteLine($"минимальное число = {getMinNumber}");
//Console.WriteLine($"максимальное число = {getMaxNumber}");
//Console.WriteLine($" разница чисел = {getResultNumber}");