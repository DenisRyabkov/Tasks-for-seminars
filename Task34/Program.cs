// Задайте массив заполненный случайными положительными трехзначными числами
// программа показывает количество четных чисел в массиве
// [345,897, 568, 234] ->2

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

int GetEvenNumber (int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if(arr[i] % 2 == 0) even++; 
    }
    return even;
}

int [] array = CreateArrayRndInt(5, 100, 1000);
PrintArray(array);
Console.WriteLine();

int getEvenNumber = GetEvenNumber(array);

Console.WriteLine($"количество четных чисел = {getEvenNumber}");
