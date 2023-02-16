// программа выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {number}");

int newDigit = NewDigit(number);
Console.WriteLine($"Новое число => {newDigit}");

int NewDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;

    return firstDigit * 10 + lastDigit;
}
