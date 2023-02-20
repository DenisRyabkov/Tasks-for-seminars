// программа принимает на вход пятизначное число
// и проверяет является ли оно полиндромом
// 14212 - нет
// 23432 - да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int reminder;
int sum = 0;
int temp = number;

while (number > 0)
{
    reminder = number % 10;
    sum = sum * 10 + reminder;
    number = number / 10;
}

if (IsPalindrome(number)) Console.WriteLine($"Число {temp} полиндром");
else Console.WriteLine($"Число {temp} НЕ полиндром");

bool IsPalindrome (int number) 
{
    if (temp == sum)
    return true;
    return false;
}  
