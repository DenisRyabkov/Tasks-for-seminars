// программа выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrey = NewArrey(number, 0, 1);
Console.WriteLine($"Массив из {number} элементов: ");
PrintArrey(arrey);

int[] NewArrey(int num, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
    return arr;
}

void PrintArrey(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"{arrey[i]} ");
        if(i < arrey.Length-1)Console.Write(",");
    }
    Console.Write("]");
}
