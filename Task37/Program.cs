// Найти произведения пар чисел в одномерном массиве
// пара - первый и последний, второй и предпоследний
// Результат вывести в новый массив

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

int [] CompositionNumber (int[] arr)
{
    int size = arr.Length / 2;
    if(arr.Length % 2 !=0) size+=1;
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i]*arr[arr.Length - 1 - i];
    }
    if(newArray.Length %2 !=0)
    newArray[newArray.Length -1] = arr[size-1];
    return newArray;
}


int [] array = CreateArrayRndInt(6, 1, 10);
int [] array2 = CompositionNumber(array);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);

