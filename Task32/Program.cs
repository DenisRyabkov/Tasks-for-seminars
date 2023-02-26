// Программа замена элементов массива
// Положительные элементы заменить на соответствующие отрицательные
// и наоборот
// [-4,-8,8,2] -> [4,8,-8,-2]

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

void GetReversElem (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     arr[i] = arr[i]* -1;   
    }
}

int [] array = CreateArrayRndInt(5, -99, 99);
PrintArray(array);
Console.WriteLine();
GetReversElem(array);
PrintArray(array);

