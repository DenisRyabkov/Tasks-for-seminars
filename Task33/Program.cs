// Определить присутствует ли заданное число в массиве
// 4; массив [6,77,32,87] -> нет
// 3; массив [3,5,66,74] -> да

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

bool FindArrayElem (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
     if (arr[i] == num) return true;   
    }
    return false;
}

int [] array = CreateArrayRndInt(5, -99, 99);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
bool existNum = FindArrayElem(array, number);

Console.WriteLine(existNum? "Да" : "Нет");
