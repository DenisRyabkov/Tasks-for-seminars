// Программа выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет
// 645 -> 5 
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("Третьей цифры нет");
else 
{
int third = GetThird(number);
Console.WriteLine($"Третья цифра => {third}");
}

int GetThird(int num)
{
    while (num > 999) num = num / 10;

    int result = num % 10;
    return result;
}
