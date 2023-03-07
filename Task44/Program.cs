// Не используя рекурсию, вывести первые N чисел Фибоначчи
// Первые два числа: 0 и 1
// N = 5 -> 01123
// N = 3 -> 011
// N = 7 -> 0112358

int[] FibonacciArray(int num)
{
    int[] fibArr = new int[num];
    fibArr[0] = 0;
    if (num > 1) fibArr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
    }
    return fibArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacciArray = FibonacciArray(number);

PrintArray(fibonacciArray);
