// Пользователь вводит с клавиатуры М чисел.
// Посчитать, сколько чисел больше 0 ввел пользователь
// 5 -> 0,7,8,-2,-2 -> 2

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i+1} -й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]> 0)
        {
            count++;
        } 
    }
    return count;
}

int Length = Prompt("Введите количество элементов:");
int[] array;
array = InputArray(Length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");

