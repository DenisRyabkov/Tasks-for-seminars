// программа принимает на вход число N
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");  
int number = Convert.ToInt32(Console.ReadLine());

if(number<=0) Console.WriteLine("Ошибка ввода");
else
{
int sum = Factorial(number);
Console.WriteLine($"Произведение числа {number} = {sum}");
}

int Factorial(int num)
{
int sum = 1;
for (int i = 1; i <= num; i++)
{
  sum = sum * i;
}
return sum;
}

