// программа задает массив из 8 элементов,
// заполненный псевдослучайными цифрами и выводит их на экран
// 1,2,5,7,19,43,7,21 -> [1,2,5,7,19,43,7,21]

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrey = NewArrey(number, 1, 100);
Console.WriteLine($"Массив из {number} элементов: ");
PrintArrey(arrey);

int[] NewArrey(int num, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(min, max);
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
