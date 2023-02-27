// Задайте одномерный массив из 123 случайных чисел 
// Найти количество элементов массива, значения которых лежат
// в отрезке [10,99]
// [5,18,123,6,2] - 1

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

int GetSchetElem (int[] arr)
{
    int schet = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if(arr[i] > 9 && arr[i] < 100) schet++; 
    }
    return schet;
}

int [] array = CreateArrayRndInt(123, 1, 999);
PrintArray(array);
Console.WriteLine();

int getSchetElem = GetSchetElem(array);

Console.WriteLine($"количество цифр в отрезке [10,99]= {getSchetElem}");
