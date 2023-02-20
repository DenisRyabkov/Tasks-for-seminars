// программа принимает на вход пятизначное число
// и проверяет является ли оно полиндромом
// 14212 - нет
// 23432 - да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit;
int revers = 0;
int temp = number;

while (number > 0)
{
    lastDigit = number % 10;
    revers = revers * 10 + lastDigit;
    number = number / 10;
}

if (IsPalindrome(number)) Console.WriteLine($"Число {temp} полиндром");
else Console.WriteLine($"Число {temp} НЕ полиндром");

bool IsPalindrome (int number) 
{
    if (temp == revers)
    return true;
    return false;
}  
