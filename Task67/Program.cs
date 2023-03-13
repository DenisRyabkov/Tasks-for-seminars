// Программа принимает на вход число
// и возвращает сумму его цифр
// 453 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);
}
Console.WriteLine($"{SumDigits(number)}");