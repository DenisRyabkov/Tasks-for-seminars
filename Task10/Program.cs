// программа принимает на вход трехзначное число
// и на выходе показывает вторую цифру числа
// 456 - > 5
// 782 - > 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondNum = SecondNum(number);
Console.WriteLine($"Вторая цифра числа => {secondNum}");

//if (number < 100 && number > 999) Console.WriteLine("Ошибка ввода");
//break;

int SecondNum(int num) 
{
    return num / 10 % 10;
}
