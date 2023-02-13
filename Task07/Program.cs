// Программа принимает на вход трехзначное число
// и на выходе показывает последнюю цифру

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastNumber = number % 10;
    Console.WriteLine($"Последняя цифра данного числа - {lastNumber}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}