// программа принимает на вход два числа 
// и выводит, является ли первое число кратным второму.
// если не кратно, то выводит остаток от деления
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 % number2 == 0) Console.WriteLine("Кратно");
//else Console.WriteLine($"Не кратно, остаток {number1 % number2}");

int result = Kratnost (number1, number2);

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine ("Не кратно, остаток" + result);

int Kratnost (int num1, int num2) 
{
    return num1 % num2;
}